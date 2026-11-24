using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyView : MonoBehaviour
{
    [SerializeField] private Transform _target;                     // プレイヤー
    [SerializeField] private List<Transform> _rootLists = new();    // ルートリスト
    private int _rootIndex = 0;                                     // 現在のルートインデックス
    private NavMeshAgent _agent;                                    // NavMeshAgentコンポーネント

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        if(_rootLists.Count > 0 && _agent != null)
        {
            _rootIndex++;
            _rootIndex %= _rootLists.Count;
            _agent.SetDestination(_rootLists[_rootIndex].position);
        }
    }

    void Update()
    {
        if(_target == null) return;
        if (!IsTargetVisible())
        {
            if (_rootLists.Count > 0 && _agent != null && IsStopped())
            {
                _rootIndex++;
                _rootIndex %= _rootLists.Count;
                _agent.SetDestination(_rootLists[_rootIndex].position);
            }
            return;
        }
        _agent.SetDestination(_target.position);
    }

    private bool IsStopped()
    {
        if (_agent == null)
        {
            return true;
        }
        if (!_agent.isStopped && _agent.remainingDistance <= _agent.stoppingDistance)
        {
            return (_agent.hasPath || _agent.velocity.sqrMagnitude == 0f);
        }
        return false;
    }

    private bool IsTargetVisible()
    {
        if(_agent == null) return false;
        Vector3 directionToTarget = _target.position - transform.position;
        float distanceToTarget = directionToTarget.magnitude;

        if(distanceToTarget > _agent.stoppingDistance)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, directionToTarget.normalized, out  hit, distanceToTarget))
            {
                if (hit.transform != _target)
                {
                    return false;
                }
            }

        }
        return true;
    }
}

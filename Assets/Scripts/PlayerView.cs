using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MovePoint();
        }
    }

    private void MovePoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray ,out hit))
        {
            NavMeshHit navHit;

            if (NavMesh.SamplePosition(hit.point, out navHit, 1.0f, NavMesh.AllAreas))
            {
                nav.SetDestination(navHit.position);
            }
        }
    }
}

/*
 * Nav機能、メモ
 * 
 * SamplePosition_ 
 * クリック位置にNavのマップが登録されているか確認
 * (クリックした位置、調べた結果、探す範囲、(仮)対象エリア)
 * 
 * NavMesh.AllArear_ シーン上にあるすべてのNavマップが対象になる
 * 
 * SetDestination_　移動先の設定関数
 * 
 * NavMeshHit_ NavMeshのマップ上のどこで見つかったかの情報結果まとめ？
 * _position 見つかった座標
 * _normal 見つかったベクトル
 * _distance 見つかった位置までの距離？(マウスクリック位置からMeshマップ場の位置までの距離)
 * _hit Meshマップ場で有効な位置だったか
 * 
 */
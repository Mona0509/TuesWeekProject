using UnityEngine;

public class PanelMove : MonoBehaviour
{
    // 移動ベクトル
    private Vector2 _vector = new Vector2(0.0f, 0.0f);

    [SerializeField] private Vector2 _targetPos;

    // 移動カウント
    private int _count = 0;

    // 移動量
    [SerializeField] private float scalar_;

    private void Start()
    {
        OnMove();
    }

    void Update()
    {
        if (0 < _count)
        {
            var pos = transform.position;
            pos.x += _vector.x;
            transform.position = pos;
            _count--;
        }
    }

    private void OnMove()
    {
        Vector2 pos = transform.position;

        // 現在の座標から目標座標までの移動ベクトルを計算する
        Vector2 vector = _targetPos - pos;

        // 移動ベクトルの量を計算する
        float length = vector.magnitude;

        // 指定した移動量で割る
        float count = length / scalar_;
        // 割った結果の数で移動ベクトルを分割する（vector_ の量は scalar_ とほぼ一致するはず）
        _vector = vector * (1.0f / count);
        _count = (int)count;

    }
}
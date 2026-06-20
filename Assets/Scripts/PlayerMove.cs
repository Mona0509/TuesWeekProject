using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using static UnityEngine.CullingGroup;

public enum State
{
    Red, Blue
}

public class PlayerMove : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 worldPos;

    int playerHP = 3;
    bool coolDownTime = false;
    SpriteRenderer sprite;

    State state;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        state = State.Red;
        sprite.color = Color.red;
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(new Vector2(mousePos.x,mousePos.y));
        //transform.position = new Mathf.Clamp(worldPos,9.33f,4.86f);
        transform.position = worldPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            state = StateChenge();
        }
    }

    public State StateChenge()
    {
        switch (state)
        {
            case State.Red:
                sprite.color = Color.blue;
                return State.Blue;
            case State.Blue:
                sprite.color = Color.red;
                return State.Red;
        }
        return state;
    }

    public async UniTask OnBulle(string tagName)
    {
        if (tagName == "Red" && state == State.Blue)
        {
            Color keepSprite = sprite.color;
            PlayerHit();
            await UniTask.Delay(2500);
            sprite.color = keepSprite;
            coolDownTime = false;
        }
        else if(tagName == "Blue" && state == State.Red)
        {
            Color keepSprite = sprite.color;
            PlayerHit();
            await UniTask.Delay(2500);
            sprite.color = keepSprite;
            coolDownTime = false;
        }
        else
        {
            await UniTask.Delay(0000);
        }
    }


    public void PlayerHit()
    {
        coolDownTime = true;
        sprite.color = Color.gray;
        --playerHP;
        if(playerHP <= 0)
        {
            Debug.Log("GameOver");
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("G‚ê‚½");
        if (coolDownTime) return;
        Debug.Log("ƒŠƒ^[ƒ“‚ð’´‚¦‚½");
        if (collision.CompareTag("Red") || collision.CompareTag("Blue"))
        {
            string tagName = collision.tag;
            OnBulle(tagName).Forget();
        }
    }
}

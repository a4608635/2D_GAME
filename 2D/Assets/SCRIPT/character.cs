
using UnityEngine;

public class character : MonoBehaviour
{
    [Header("跳越高度"),Range(10,1000)]
    public int jump = 50;
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡、取消:沒死")]
    public bool dead;

    //為遊戲物件取名 GameObject
    public GameObject sc, gm;
    [Header("剛體")]
    public Rigidbody2D  r2d;
    public GameManager gmm;

    [Header("音效")]
    public AudioSource aud;
    public AudioClip soundjump, soundhit, soundadd;

    /// <summary>
    /// 神父跳起來
    /// </summary>
    private void Jump()
    {
        if (dead)
            {
                return;
            }
        // GetKeyDown = 按下
        // keycode = 選擇按鍵
        // Mouse0 = 左鍵  1 = 右鍵 2 = 滾輪
        // 如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            

            print("按下左鍵");

            // 遊戲物件的名稱.方法(布林值)
            // 顯示分數
            sc.SetActive(true);
            // 顯示GM
            gm.SetActive(true);

            // 剛體.重力=1
            r2d.gravityScale = 1;
            // 剛體.睡覺
            r2d.Sleep();
            // Y=跳越高度
            // 剛體,推力(X,Y)
            r2d.AddForce(new Vector2(0,jump));

            // 音源.方法(音效,音量);
            aud.PlayOneShot(soundjump,5);



        }
        //可消除
        // print(r2d.velocity);
        // velocity 剛體加速度(x,y)左右x,上下y
        r2d.SetRotation(5 * r2d.velocity.y);
    }

    /// <summary>
    /// 神父是否死亡
    /// </summary>
    private void Dead()
    {
        if (dead)
        {
            return;
        }
        dead = true;
        gmm.GameOven();
        aud.PlayOneShot(soundadd);
    }

    /// <summary>
    /// 神父是否通過水管
    /// </summary>
    public void Pass()
    {
        if (dead)
        {
            return;
        }
        gmm.App(1);
        print("加分");
        aud.PlayOneShot(soundhit);
        

    }

    //監聽完家輸入:滑鼠、鍵盤、搖桿
    private void Update()
    {
        Jump();
        
    }

    // 碰撞事件:碰撞到其他碰撞器的時候執行一次(碰到物件的碰撞資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);

        Dead();
    }
    // 觸發事件:處發其他碰撞器開始時執行一次(針對勾選 IsTrigger的物件)
   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "04_水管"|| collision.gameObject.name == "04_水管 (1)")
        {
            Dead();
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "加分")
        {
            Pass();
        }
    }
}

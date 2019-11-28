
using UnityEngine;

public class character : MonoBehaviour
{
    [Header("跳越高度"),Range(10,100)]
    public int jump = 50;
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡、取消:沒死")]
    public bool dead;

    //為遊戲物件取名 GameObject
    public GameObject sc, gm;

    /// <summary>
    /// 神父跳起來
    /// </summary>
    private void Jump()
    {
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
            
        }
    }

    /// <summary>
    /// 神父是否死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 神父是否通過水管
    /// </summary>
    public void Pass()
    {

    }

    //監聽完家輸入:滑鼠、鍵盤、搖桿
    private void Update()
    {
        Jump();
    }
}

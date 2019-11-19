
using UnityEngine;

public class character : MonoBehaviour
{
    [Header("跳越高度"),Range(10,100)]
    public int jump = 50;
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡、取消:沒死")]
    public bool dead;

    /// <summary>
    /// 神父跳起來
    /// </summary>
    private void Jump()
    {

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

    private void Start()
    {
        
    }
}

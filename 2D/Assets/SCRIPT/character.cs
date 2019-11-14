
using UnityEngine;

public class character : MonoBehaviour
{
    [Header("跳越高度"),Range(10,100)]
    public int jump = 50;
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡、取消:沒死")]
    public bool dead;
}

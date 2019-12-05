
using UnityEngine;

public class floor : MonoBehaviour
{
    // static 靜態 隱藏
    // 此類別共用 包含子類別
    //[Header("速度"),Range(1F,100F)]
    public static float fspeed = 10;
    [Header("變形")]
    public Transform GAY;

    /// <summary>
    /// 地板的速度
    /// </summary>
    private void Fspeed()
    {
        GAY.Translate(-fspeed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        Fspeed();        
    }
}

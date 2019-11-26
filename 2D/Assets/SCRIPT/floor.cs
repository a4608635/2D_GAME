
using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度"),Range(1F,100F)]
    public float fspeed = 10;
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

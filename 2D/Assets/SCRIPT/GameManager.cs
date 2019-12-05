
using UnityEngine;
using UnityEngine.UI; // 匯入API

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int fraction1;
    [Header("最高分數")]
    public int fraction2;

    // GameObject 可以存放預置物以及廠景上的物件
    [Header("水管")]
    public GameObject pipe;
    [Header("介面")]
    public GameObject Ui;
    [Header("分數介面")]
    public Text text;
    public Text text2;

    /// <summary>
    /// 生成水管
    /// </summary>
    public void SpawnPipe()
    {
        // 因為有繼承此類別才可簡寫Object
        // Object.Instantiate(pipe);

        // 浮點數 = 隨機.靜態方法(最小,最大)
        float y = Random.Range(-0.2f, 2f);

        // 三維向量 Vector3 - x, y, z
        Vector3 pos = new Vector3(4.1F, y, 0);

        // 四元數 Quaternion - x, y, z, w
        Quaternion rot = new Quaternion(0, 0, 0, 0);

        Instantiate(pipe, pos, rot);
    }

    /// <summary>
    /// 加分功能
    /// </summary>
    /// <param name="app">加分的數字</param>
    public void  App(int app)
    {
        fraction1 += app;
        //text.text = fraction1 + "";
        text.text = fraction1.ToString(); //整數.轉文字()

        Fraction2();
    }

    private void Fraction2()
    {

        // 如果目前分數>最高分數
        if (fraction1>fraction2)
        {
            // 最高分數=目前分數
            fraction2 = fraction1;
            text2.text = fraction2.ToString();
            PlayerPrefs.SetInt("最高分數", fraction2);
        }
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOven()
    {
        Ui.SetActive(true);
        floor.fspeed = 0;
    }

    private void Start()
    {
        //延遲重複調用 
        //語法: 延遲重複調用=名稱,時間,延遲時間
        InvokeRepeating("SpawnPipe", 0 , 3);        
        // 取得資料
        fraction2 = PlayerPrefs.GetInt("最高分數");
        text2.text = fraction2.ToString();
    }

}

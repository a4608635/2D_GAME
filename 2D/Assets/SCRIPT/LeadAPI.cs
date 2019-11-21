
using UnityEngine;

public class LeadAPI : MonoBehaviour
{
    private void Start()
    {
        print("信教啦!");

        // object 任何類型：int、float、string、bool
        Debug.Log("你敢不信教!!!!");

        // 靜態成員的取得方法
        print(Random.value);

        // 練習取得PI
        print(Mathf.PI);

        // 靜態方法： 類別.方法(對應的參數);
        print ("隨機範圍:"+Random.Range( 130.1F,260.9f));

        // object 任何類型：int、float、string、bool
        Debug.Log("我不想學英文阿!");
        Debug.LogWarning("當心英文");
        Debug.LogError("英文錯了阿!");
    }

    //Update=60禎一直觸發 用來重覆偵測觸發
    private void Update()
    {
        // 輸入.按鍵名稱
        print(Input.inputString);

        // 練習：請練習偵測玩家有沒有按 s
        print(Input.GetKeyDown("s"));
    }
}

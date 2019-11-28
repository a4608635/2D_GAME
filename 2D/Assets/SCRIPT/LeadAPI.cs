
using UnityEngine;

public class LeadAPI : MonoBehaviour
{
    //要給 Transform 一個物件才能使用
    public Transform tranA;
    public Transform tranB;

    //地板
    public Transform GAY;

    //圖片渲染器 SpriteRenderer
    public SpriteRenderer spriteA;
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

        // 分靜態屬性：實體類別.屬性
        // print(Transform.position); // 錯誤寫法
        print(tranA.position);
        print(tranB.position);

        // 存放非靜態屬性

        // 位置
        tranA.position = new Vector3(-1, 0, 0);
        //大小
        tranA.localScale = new Vector3(5, 5, 5);

        // flipX 左右相反 結果只能是布林值
        spriteA.flipX = true;
        // flipY 上下相反 結果只能是布林值
        spriteA.flipY = true;
    }

    //Update = 60 禎一直觸發 用來重覆偵測觸發
    private void Update()
    {
        // 輸入.按鍵名稱
        print(Input.inputString);

        // 練習：請練習偵測玩家有沒有按 s
        print(Input.GetKeyDown("s"));

        //非靜態方法：實體類別.方法(對應的引數)
        //Rotate 旋轉
        tranA.Rotate(0, 0, 10);
        //tranB.Rotate(0, 0, 10);

        GAY.Translate(-0.1F, 0, 0);
        

    }
}

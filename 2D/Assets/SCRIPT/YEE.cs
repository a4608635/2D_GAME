
using UnityEngine;

public class YEE : MonoBehaviour
{
    // 定義方法 Method (宣告函式、功能)
    // 語法：
    // 修飾詞 方式傳回類型 方法名稱 ( ) { }
    // 參數語法：參數類型 參數名稱
    // void 無傳回
    private void Test()
    {

    }

    /// <summary>
    /// 開車子
    /// </summary>
    /// <param name="speed">車子的速度</param>
    private void Drive(int speed)
    {
        print("引擎音效");
        //字串可以使用+號與其他形態串接，結果為字串
        print("車子正在往前開，時速:"+speed);
    }

    //多重參數使用，逗號隔開
    //參數不能重複名稱，可以與欄位相同
    //參數可以給預設值，選填式參數
    //選填式參數只能寫在最後面
    private void arrow(int quantity, string direction = "前方" ,string attributes = "無")
    {
        print("弓箭數量：" + quantity);
        print("弓箭方向" + direction);
        print("弓箭屬性" + attributes);
    }

    //有傳回
    private string Name(string name)
    {
        return "嗨~" + name + "你好~";
    }

    private void Start()
    {
        // 呼叫方法，給予對應的引數
        Drive(99);
        Drive(120);
        // 不填寫選填式參數，以預設值執行方式
        arrow(1);
        arrow(1, "四周");
        // 可以具名使用指定的選填式參數
        arrow(1, attributes: "死靈");
        arrow(100, "全範圍", "死靈");

        // 區域欄位，不需要修飾詞
        string AA = Name("江曜宇");
        print(AA);
        // 將傳回方法當作傳回類型資料使用
        print(Name("七瀨"));
        
    }
}

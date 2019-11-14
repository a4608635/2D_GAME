
using UnityEngine;

public class NewBehaviourScript12 : MonoBehaviour
{
    // Start 事件
    // 事件:在特定時間點以指定次次執行
    // 開始是建:播放後執行一次
    // 語法:
    // 修飾詞 傳回類型 名稱 () {}
    private void Start()
    {
        //輸出方式(物件);
        print("哈囉!你要信教嗎?!");
    }

    // Update 更新事件
    // 更新事件:每秒執行約 60 次 (60FPS frame per second)
    private void Update()
    {
        print("yeeeeeee");
    }
}

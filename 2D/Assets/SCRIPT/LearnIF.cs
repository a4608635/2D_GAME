
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool open;

    public int QQQ;

    private void Start()
    {
       // 判斷式 if (switch)
       // 語法:
       // if (布林值) { 當 if () 布林值為 true 執行這裡 }

       if (true)
	   {
         print("嗨~");
	   } 
    }

    private void Update()
    {
        // if () 布林值為 true 會執行
        if (open)
        {
           print("開門");
        }
        // if () 布林值為 false 會執行 else {} (否則)
        else
        {
            print("關門");
        }
        
        //練習 爆擊
        if (QQQ >= 150)
        {
            print("攻擊10倍");
        }
        else if (QQQ >= 100)
        {
            print("攻擊5倍");
        }
        else if (QQQ>=50)
        {
            print("攻擊2倍");
        }
        else
        {

        }

        
    }

   
        
       

}

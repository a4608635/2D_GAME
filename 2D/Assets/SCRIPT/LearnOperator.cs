using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;

    private void Start()
    {
        // 數學運算子
        // + - * / %
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;       // 等號右邊先執行再存回左邊 11
        print(a++);      // 先輸出再執行遞增 先輸出11再+1 系統儲存12
        print(++a);      // 先執行遞增再輸出 12先+1 系統再輸出13

        //比較運算子
        //結果為布林值
        // >大於 <小於 >=大於等於 <=小於等於 ==等於 !=不等於
        print(c > d);    // true    
        print(c < d);    // false
        print(c >= d);   // true 
        print(c <= d);   // false
        print(c == d);   // false
        print(c != d);   // true 

        // 邏輯運算子
        // 結果是布林值
        // 並且 &&
        // 規則:只要有一個 false 就會傳回 false
        print(true && true);       //true
        print(true && false);      //false
        print(false && true);      //false
        print(false && false);     //false

        // 或者||
        // 規則:只要有一個true 就會傳回 true
        print(true && true);         //true
        print(true && false);        //true
        print(false && true);        //true
        print(false && false);       //false

        // 相反(顛倒)!
        // 作用:將布;林值變相反
        print(!true);    //false
        print(!false);   //true

    }
}

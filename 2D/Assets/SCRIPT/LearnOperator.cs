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

        // >大於 <小於 >=大於等於 <=小於等於 ==等於 !=不等於
        print(c > d);    // true    
        print(c < d);    // false
        print(c >= d);   // true 
        print(c <= d);   // false
        print(c == d);   // false
        print(c != d);   // true 
    }
}

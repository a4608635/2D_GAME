﻿using UnityEngine; //usity的API API是啥自己查
//類別 類別名稱 #注意類別名稱要和黨名一樣
public class NewBehaviourScript : MonoBehaviour
{
    // 東西一定要在{}裡
    // 定義欄位 Field (宣告變數)
    // 語法:
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 數字預設值都是0
    // 私人 private 隱藏(這是預設的 會看不到)
    // 公開 public  顯示(要在欄位類型前輸入)
    // 丟進去前注意座標
    public int level = 1;            //整數   預設0
    public float speed = 10.5f;       //浮點數 預設0 小數點要+F
    public string prop = "紅色藥水"; //字串   預設""
    public bool mission = true;      //布林值 預設 false

    //屬性
    //語法:[屬性名稱(屬性內容)]
    //[標題("標題內容")]
    [Header("血量")]
    public int HP = 100;
    [Header("跳躍高度")]
    public float jump = 99.9F;

    //[提示("提示內容")]
    [Header("死亡")]
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡、取消:沒死")]
    public bool dead;
    //[範圍(最小值，最大值)]
    [Header("魔力"), Range(0, 999)]
    public int mp = 50;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class ViewTime : MonoBehaviour
{
    /**
    <summary>
    Timeオブジェクトに時間を表示させる
    L20：countTime変数に経過した時間を格納する
    L21：viewTimeに経過時間を文字にして格納する(f0で整数のみを出す)
    <summary>
    */
    private float countTime = 0.0f;
    public Text viewTime;

    void Update(){
        countTime = Time.time;
        viewTime.text = countTime.ToString("f0") + "秒";
    }
}
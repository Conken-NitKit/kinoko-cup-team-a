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
    時間を測る。
    L28のifでflagが１の時時間をスタートさせる。
    L33で時間を表示させる。
    <summary>
    */
    public UnityEngine.UI.Text TimeText;
    public static float countTime;
    private int flag;

    void Start()
    {
        countTime = 0;
        flag = 1;
    }

    void Update()
    {
        if(flag == 1) //タイマースタート
        {
            countTime += Time.deltaTime;
        }

        TimeText.text = countTime.ToString("F0") + "秒";
    }
}
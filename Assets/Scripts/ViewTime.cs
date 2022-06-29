using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class ViewTime : MonoBehaviour
{
    public UnityEngine.UI.Text TimeText;
    public static float countTime;
    private int flag;
    public GameObject Panel;

    /**
    <summary>
    時間を測る。
    Update内でflagが１の時、タイマースタート
    F0で整数だけ表示する
    <summary>
    */

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
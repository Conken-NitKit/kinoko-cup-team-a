using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ViewTime : MonoBehaviour
{
    public static float countTime = 0.0f;
    public bool TimeActive;
    public UnityEngine.UI.Text viewTime;
    public GameObject judgeObject;
    private JudgeGame judgeScript;

    /**
    <summary>
    設定の説明ー＞
    JudgeObjectやJudgeGameはflagを呼び出すための変数

    適用対象ー＞
    Timeオブジェクト
    
    動作の説明ー＞
    Start関数でJudgeObjectクラスを呼び出しflag変数を取得
    flagが０の時はタイマーを動かし、flagが1の時は止める


    flag = 0    ゲーム中
    flag = 1    ゲームオーバー中

    <summary>
    */

    void Start()
    {
        Debug.Log(5);
        TimeActive = false;
        judgeObject = GameObject.Find("JudgeObject");
        judgeScript = judgeObject.GetComponent<JudgeGame>();
    }

    void Update(){
        
        if(TimeActive)
        {
            Debug.Log(6);
            countTime += Time.deltaTime;
        }
        if(judgeScript.flag == 1)
        {
            Debug.Log(7);
            TimeActive = false;
        }
        
        viewTime.text = countTime.ToString("f0") + "秒";
    }

    public void GameStart()
    {
        Debug.Log(8);
        TimeActive = true;
    }

    public void TitleView()
    {
        Debug.Log(9);
        countTime = 0f;
        TimeActive = false;
    }

}
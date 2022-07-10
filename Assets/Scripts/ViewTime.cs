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
    public GameObject judgeOverObject;
    private JudgeGameOver judgeOverScript;
    public GameObject judgeSuccessObject;
    private JudgeSuccess judgeSuccessScript;

    /**
    <summary>
    JudgeSuccessとJudgeGameOverからflagを取ってくる

    deltaTimeで時間を加算

    TimeActiveで時間を再生するかしないか決める

    成功した時、失敗した時時間を止めるために
    if文でTimeActiveをfalseに

    タイトルボタンを押したら時間はリセットするために０を代入
    <summary>
    */

    void Start()
    {
        TimeActive = false;
        judgeOverObject = GameObject.Find("JudgeOver");
        judgeOverScript = judgeOverObject.GetComponent<JudgeGameOver>();
        judgeSuccessObject = GameObject.Find("JudgeSuccess");
        judgeSuccessScript = judgeSuccessObject.GetComponent<JudgeSuccess>();
    }

    void Update(){
        
        if(TimeActive)
        {
            countTime += Time.deltaTime;
            Debug.Log("時間加算中");
        }
        if(judgeOverScript.flag == 1 | judgeSuccessScript.flag == 2)
        {
            TimeActive = false;
            Debug.Log("時間停止");
        }
        
        viewTime.text = countTime.ToString("f0") + "秒";
    }

    public void GameStart()
    {
        Debug.Log("時間スタート");
        TimeActive = true;
    }

    public void TitleView()
    {
        countTime = 0f;
        TimeActive = false;
    }

}
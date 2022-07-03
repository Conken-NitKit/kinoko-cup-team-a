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
        if(judgeScript.flag == 1 | judgeScript.flag == 2)
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagePanel : MonoBehaviour
{
    private GameObject judgeObject;
    JudgeGame judgeScript;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject GamePanel;

    /**
    <summary>
    設定の説明ー＞
    JudgeObjectやJudgeGameはflagを呼び出すための変数

    適用対象ー＞
    UI Manager

    動作の説明ー＞
    ゲームオーバーのパネルを表示するスクリプト
    JudgeGameを呼び出してflag変数を呼び出す
    flagが0の時はGameOverを非表示に、flagが1の時は表示する。
    <summary>
    */
    void Start()
    {
        Debug.Log(1);
        judgeObject = GameObject.Find("JudgeObject");
        judgeScript = judgeObject.GetComponent<JudgeGame>();
    }

    void Update()
    {
        if(judgeScript.flag == 1)
        {
            Debug.Log(2);
            GameOverPanel.SetActive(true);
            TitlePanel.SetActive(false);
        }
    }

    public void TitleView()
    {
        Debug.Log(3);
        GameOverPanel.SetActive(false);
        TitlePanel.SetActive(true);
    }

    public void GameStart()
    {
        Debug.Log(4);
        GameOverPanel.SetActive(false);
        TitlePanel.SetActive(false);
    }
}
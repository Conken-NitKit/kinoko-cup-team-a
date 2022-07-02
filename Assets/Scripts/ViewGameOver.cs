using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGameOver : MonoBehaviour
{
    GameObject JudgeObject;
    JudgeGame JudgeGame;
    [SerializeField] GameObject GameOverPanel;

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
        JudgeObject = GameObject.Find("JudgeObject");
        JudgeGame = JudgeObject.GetComponent<JudgeGame>();
    }

    void Update()
    {
        if(JudgeGame.flag == 0)
        {
            GameOverPanel.SetActive(false);
        }
        if(JudgeGame.flag == 1)
        {
            GameOverPanel.SetActive(true);
        }
    }
}

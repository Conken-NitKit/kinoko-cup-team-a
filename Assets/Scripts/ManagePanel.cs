using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagePanel : MonoBehaviour
{
    private GameObject judgeOverObject;
    JudgeGameOver judgeOverScript;
    private GameObject judgeSuccessObject;
    JudgeSuccess judgeSuccessScript;

    [SerializeField] GameObject GamaPanel;
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject SuccessPanel;

    /**
    <summary>
    JudgeSuccessとJudgeGameOverからflagを取ってくる
    flagが1の時失敗 ー＞ ゲームオーバーパネルを表示
    flagが２の時成功 ー＞ 成功パネルを表示

    startボタンをタイトルパネルに設置
    TitleViewボタンを成功パネルとゲームオーバーパネルに表示

    TitleViewボタンでシーンをロードする
    <summary>
    */

    void Start()
    {
        judgeOverObject = GameObject.Find("JudgeOver");
        judgeOverScript = judgeOverObject.GetComponent<JudgeGameOver>();
        judgeSuccessObject = GameObject.Find("JudgeSuccess");
        judgeSuccessScript = judgeSuccessObject.GetComponent<JudgeSuccess>();
    }

    void Update()
    {
        if(judgeOverScript.flag == 1)
        {
            Debug.Log("judgeOverScript.flag == 1");
            GamaPanel.SetActive(false);
            GameOverPanel.SetActive(true);
            TitlePanel.SetActive(false);
            SuccessPanel.SetActive(false);
        }

        if(judgeSuccessScript.flag == 2)
        {
            Debug.Log("judgeOverScript.flag == 2");
            GamaPanel.SetActive(false);
            GameOverPanel.SetActive(false);
            TitlePanel.SetActive(false);
            SuccessPanel.SetActive(true);
        }
    }

    public void GameStart()
    {
        GamaPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        TitlePanel.SetActive(false);
        SuccessPanel.SetActive(false);
    }

    public void TitleView()
    {
        SceneManager.LoadScene(0);
    }

}
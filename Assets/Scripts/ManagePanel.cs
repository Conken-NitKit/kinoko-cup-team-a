using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagePanel : MonoBehaviour
{
    private GameObject judgeObject;
    JudgeGame judgeScript;
    private GameObject successObject;
    SuccessObject successScript;

    [SerializeField] GameObject GameOverPanel;
    [SerializeField] GameObject TitlePanel;
    [SerializeField] GameObject SuccessPanel;

    void Start()
    {
        Debug.Log(1);
        judgeObject = GameObject.Find("JudgeObject");
        judgeScript = judgeObject.GetComponent<JudgeGame>();
        successObject = GameObject.Find("SuccessObject");
        successScript = successObject.GetComponent<SuccessObject>();
    }

    void Update()
    {
        if(judgeScript.flag == 1)   //あたった時
        {
            Debug.Log(2);
            GameOverPanel.SetActive(true);
            TitlePanel.SetActive(false);
            SuccessPanel.SetActive(false);
        }

        if(successScript.flag == 2)   //あたった時
        {
            Debug.Log(13);
            GameOverPanel.SetActive(false);
            TitlePanel.SetActive(false);
            SuccessPanel.SetActive(true);
        }
    }

    public void GameStart()
    {
        Debug.Log(4);
        GameOverPanel.SetActive(false);
        TitlePanel.SetActive(false);
        SuccessPanel.SetActive(false);
    }

    public void TitleView()
    {
        Debug.Log(3);
        SceneManager.LoadScene(0);
    }

}
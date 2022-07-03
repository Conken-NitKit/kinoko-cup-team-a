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

    void Start()
    {
        Debug.Log(1);
        judgeObject = GameObject.Find("JudgeObject");
        judgeScript = judgeObject.GetComponent<JudgeGame>();
    }

    void Update()
    {
        if(judgeScript.flag == 1)   //あたった時
        {
            Debug.Log(2);
            GameOverPanel.SetActive(true);
            TitlePanel.SetActive(false);
        }
    }
    public void GameStart()
    {
        Debug.Log(4);
        GameOverPanel.SetActive(false);
        TitlePanel.SetActive(false);
    }

    public void TitleView()
    {
        Debug.Log(3);
        SceneManager.LoadScene(0);
    }

}
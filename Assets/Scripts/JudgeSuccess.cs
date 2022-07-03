using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JudgeSuccess : MonoBehaviour
{
    public int flag;

    /**
    <summary>
    flagは上の棒にあたったかどうか判断するもの
    上の棒に当てることに成功するとflagが2になる
    <summary>
    */

    void Start()
    {
        flag = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Character")
        {
           flag = 2;
        }
    }
}
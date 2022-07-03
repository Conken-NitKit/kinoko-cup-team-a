using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JudgeGameOver : MonoBehaviour
{
    public int flag;

    /**
    <summary>
    lagは下の棒にあたったかどうか判断するもの
    下の棒に当たるとflagが1になる
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
           flag = 1;
        }
    }
}
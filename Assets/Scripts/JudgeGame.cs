using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JudgeGame : MonoBehaviour
{
    public int flag;

    void Start()
    {
        Debug.Log(10);
        flag = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Character")
        {
           Debug.Log(11);
           flag = 1;
        }
    }
}
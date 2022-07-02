using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JudgeGame : MonoBehaviour
{
    public int flag;
    
    /**
    <summary>
    設定の説明ー＞
    動物と下に当たった時の判断をする棒を置く
    動物にridgid body2Dとbox collider、棒にbox colliderをつける
    動物にtagのCharacterを設定
    flag
    下のOnTriggerEnter2Dはcharacterに何か当たると発動するメソッド
    JudgeObjectに適用する

    適用対象ー＞
    JudgeObject

    動作の説明ー＞
    ifでCharacterタグのものが当たったらflagを1にする
    <summary>
    */

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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JudgeGame : MonoBehaviour
{
    /**
    <summary>
    動物と下に当たった時の判断をする棒を置く
    動物にridgid body2Dとbox collider、棒にbox colliderをつける
    棒にtagのCharacterを設定
    GameOverシーンを新しく作った

    再生すると動物が棒に当たりGameOverシーンに移動する

    下のOnTriggerEnter2Dはcharacterに何か当たると発動するメソッド
    ifでCharacterタグのものが当たったらGameOverシーンへ移動
    <summary>
    */
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Character")
        {
           SceneManager.LoadScene("GameOver");
        }
    }
}
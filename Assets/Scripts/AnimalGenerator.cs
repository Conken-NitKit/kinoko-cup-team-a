using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour{

    public GameObject[] animal;
    private int number;

    public bool isStop;
    public bool isGameOver;
    public bool isStart;

    public GameObject judgeOverObject;
    private JudgeGameOver judgeOverScript;
    public GameObject judgeSuccessObject;
    private JudgeSuccess judgeSuccessScript;


    void Start(){
        Init();
    }

    void Init(){
        isStart = false;
        isGameOver = false;
        judgeOverObject = GameObject.Find("JudgeOver");
        judgeOverScript = judgeOverObject.GetComponent<JudgeGameOver>();
        judgeSuccessObject = GameObject.Find("JudgeSuccess");
        judgeSuccessScript = judgeSuccessObject.GetComponent<JudgeSuccess>();
    }

    void Update()
    {
        if(isGameOver){
            return;
        }

        if(CheckMove(animal[number].GetComponent<Rigidbody2D>())){
            AppearObject();
        }

        if(isStart){
            isStart = false;
        }

        if(judgeOverScript.flag == 1 | judgeSuccessScript.flag == 2)
        {
            isGameOver = true;
        }

        if(Input.GetKey(KeyCode.A)){
            Transform tr = animal[number].transform;
            tr.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.S)){
            if(!isStop){
            Transform tr = animal[number].transform;
            tr.Rotate(new Vector3(0, 0, 90));
        }
        }

        if(Input.GetKey(KeyCode.D)){
            Transform tr = animal[number].transform;
            tr.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }
    }

    public void GameStart(){
        AppearObject();
        isStart = true;
    }

    private void AppearObject(){
        number = Random.Range(0, animal.Length);
        animal[number] = Instantiate(animal[number], new Vector3(0,3,0), Quaternion.identity);
    }

    bool CheckMove(Rigidbody2D rb){
        if(rb.IsSleeping()){
            isStop = true;
            return isStop;
        }
        return isStop = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right*speed*Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right*speed*Time.deltaTime;
        }
    }
}

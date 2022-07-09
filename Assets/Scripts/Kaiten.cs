using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten : MonoBehaviour
{
    public void TurnRight(){
            Debug.Log("右回転");
            Migikaiten();
    }

    void Migikaiten(){
        transform.Rotate(new Vector3(0, 0, 90));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControlLeft : MonoBehaviour
{
    private GameObject Animal;
    //Animal = GameObject.FindWithTag("Character");
    [SerializeField] private void Pushed()
    {
        Animal = GameObject.FindWithTag("Character");
        Animal.transform.position = new Vector3(-5,0,0);
    }
}

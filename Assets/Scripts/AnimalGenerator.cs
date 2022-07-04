using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalGenerator : MonoBehaviour{

    [SerializeField] private GameObject[] animal;
    private int number;
    //private void OnCollisionEnter(Collision collision);

    void Start()
    {
        Animal();
    } 
      
    void FixedUpdate()
    {
        if(Input.GetKeyUp(KeyCode.A) | Input.GetKeyUp(KeyCode.D))
        {
           Animal();
        }
    }

    private void Animal(){
        number = Random.Range (0, animal.Length);
        //animal[number].GetComponent<Rigidbody2D>().isKinematic = true;
        Instantiate(animal[number],new Vector3(0, 0, 0),transform.rotation);
    }   
}
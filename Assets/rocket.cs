using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    public GameObject rocky;
    void Start()
    {
       
        rigidBody = GetComponent<Rigidbody>();
    }
    //SİLİNDİR VE KÜP ARASINDAKİ COLLİDER FARKI SORUNU !!
    void Update()
    {
        processInput();
    }

     void processInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddRelativeForce(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddRelativeForce(Vector3.right);
        }   
    }
}

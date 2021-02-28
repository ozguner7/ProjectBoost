using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    new AudioSource audio;
    public GameObject rocky;  

    public Image ic;
    public float yakit, maxyakit=1000;
    public float yakma;
    
    void Start()
    {       
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        rotate();
        thrust();
    }

     void rotate()
    {
        rigidBody.freezeRotation = true;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }

     void thrust()
     {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            yakit -= Time.deltaTime * yakma;
            ic.fillAmount = yakit / maxyakit;
            if (!audio.isPlaying)
                audio.Play();
        }
        else
        {
            audio.Stop();
        }
     }
    
}





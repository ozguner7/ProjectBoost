using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    new AudioSource audio;
    public GameObject rocky;
    
    void Start()
    {       
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
    //SİLİNDİR VE KÜP ARASINDAKİ COLLİDER FARKI SORUNU !!
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
            if (!audio.isPlaying)
                audio.Play();
        }
        else
        {
            audio.Stop();
        }
    }

    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "TOP")
    //    {
    //        Destroy(col.gameObject);
    //    }
    //}
}





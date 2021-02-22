using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pervane : MonoBehaviour
{
    Rigidbody rigidBody1;
    public float speed;
    void Start()
    {
        rigidBody1 = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rotate1();
    }
    void rotate1()
    {
        transform.Rotate(Vector3.forward*speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topscrpit : MonoBehaviour
{
    public GameObject top;
    public GameObject rocket;
    public float gravityboost;
    Rigidbody rigidbody2;
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody>();
        rigidbody2.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        falling();
    }
    void falling()
    {
        if(top.transform.position.x-rocket.transform.position.x <= 6f)
        {
            rigidbody2.AddRelativeForce(Vector3.down*gravityboost);
        }
        else
        {
            //gravityboost = 0;
        }
    }
}

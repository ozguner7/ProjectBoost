using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duvar : MonoBehaviour
{
    public GameObject duvarr;  
    public float hiz1;
    Rigidbody rigidbody3;
    
    void Start()
    {
        rigidbody3 = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        loopMove();
        rigidbody3.AddForce(Vector3.up*hiz1);
    }
    void loopMove()
    {
        //for(duvarr.transform.position.y=18.5; duvarr.transform.position.y<=30f; hiz1=hiz1)
        if (duvarr.transform.position.y <= 30f)
        {
            hiz1 = hiz1;
        }
        else if (duvarr.transform.position.y >= 5.5f)
        {
            hiz1 = -hiz1;
        }
    }
}

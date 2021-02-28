using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascrpit : MonoBehaviour
{
    public Transform rocket;
    public Vector3 camera1;
    

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = rocket.position + camera1;
        
    }
}

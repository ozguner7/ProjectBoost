using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topscrpit : MonoBehaviour
{
    public GameObject top;
    public GameObject rocket;
    float gravityboost;

    Rigidbody rigidbody2;
    AudioSource rock;
    Collision col;
    MeshRenderer silmek;
    SphereCollider yoketmek;

    void Start()
    {
        
        rigidbody2 = GetComponent<Rigidbody>();
        rigidbody2.useGravity = false;
        silmek = GetComponent<MeshRenderer>();
        silmek.enabled = false;
        rock = GetComponent<AudioSource>();            
        yoketmek = GetComponent<SphereCollider>();
    }

    void Update()
    {
        falling();     
    }
    void falling()
    {
        if (top.transform.position.x - rocket.transform.position.x <= 6f)
        {          
            gravityboost = 18f;
            rigidbody2.AddRelativeForce(Vector3.down * gravityboost);
            silmek.enabled = true;
        }
        else
        {
            gravityboost = 0;           
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "FLOOR")
        {
            rock.Play();
            Destroy(silmek);
            Destroy(yoketmek);
        }
        else if (col.gameObject.tag == "ROCKET")
        {
            rock.Play();
            Destroy(silmek);
            Destroy(yoketmek);
        }
    }
}



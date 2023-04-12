using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving22 : MonoBehaviour
{
    float pos1 = 110f;
    float pos2 = 120f;
    Vector3 velo;
    Vector3 velo2;
    Vector3 zero = new Vector3(0f, 0f, 0f);
    Rigidbody rb;
    GameObject thisenemy;
    void Start()
    {
        thisenemy = this.gameObject;
        velo = new Vector3(2f,0,0);
        velo2 = new Vector3(-2f, 0, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (thisenemy.transform.position.x <= pos1)
        {
            rb.velocity = velo;
            rb.angularVelocity = zero;
        }
        else if (thisenemy.transform.position.x >= pos2)
        {
            rb.velocity = velo2;
        }
    }
}

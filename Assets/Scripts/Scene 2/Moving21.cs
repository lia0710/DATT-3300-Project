using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving21 : MonoBehaviour
{
    float pos1 = 97f;
    float pos2 = 103f;
    Vector3 velo;
    Vector3 velo2;
    Vector3 zero = new Vector3(0f, 0f, 0f);
    Rigidbody rb;
    GameObject thisenemy;
    void Start()
    {
        thisenemy = this.gameObject;
        velo = new Vector3(0,0,1f);
        velo2 = new Vector3(0, 0, -1f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (thisenemy.transform.position.z <= pos1)
        {
            rb.velocity = velo;
            rb.angularVelocity = zero;
        }
        else if (thisenemy.transform.position.z >= pos2)
        {
            rb.velocity = velo2;
        }
    }
}

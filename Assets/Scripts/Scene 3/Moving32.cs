using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving32 : MonoBehaviour
{
    public static int state;//1,2,3,4
    public static bool initial = true;
    Vector3 velo;
    Vector3 velo2;
    Vector3 velo3;
    Vector3 velo4;
    Vector3 zero = new Vector3(0f, 0f, 0f);
    Rigidbody rb;
    GameObject thisenemy;
    void Start()
    {
        if (initial)
        {
            state = 1;
            initial = false;
        }
        thisenemy = this.gameObject;
        velo = new Vector3(4f,0,0);
        velo2 = new Vector3(-4f, 0, 0);
        velo3 = new Vector3(0, 0, 4f);
        velo4 = new Vector3(0, 0, -4f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (thisenemy.transform.position.x == 113 && thisenemy.transform.position.z == 114)
        {
            state = 1;
        }

        if (thisenemy.transform.position.z <= 114f && thisenemy.transform.position.x >= 113f && state != 2 && state != 3)
        {
            rb.velocity = velo3;
            rb.angularVelocity = zero;
            state = 1;
        }
        else if (thisenemy.transform.position.z >= 122f && thisenemy.transform.position.x >= 113f && state != 3 && state != 4)
        {
            rb.velocity = velo2;
            state = 2;
        }
        else if (thisenemy.transform.position.x <= 105f && thisenemy.transform.position.z >= 122f && state != 4 && state != 1)
        {
            rb.velocity = velo4;
            state = 3;
        }
        else if (thisenemy.transform.position.z <= 114f && thisenemy.transform.position.x <= 105f && state != 1 && state != 2)
        {
            rb.velocity = velo;
            state = 4;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}

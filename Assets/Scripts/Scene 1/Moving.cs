using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    float pos1 = 87f;
    float pos2 = 93f;
    Vector3 velo;
    Vector3 velo2;
    Vector3 zero = new Vector3(0f, 0f, 0f);
    Rigidbody rb;
    GameObject thisenemy;
    GameObject player;
    public bool collided1 = false;
    void Start()
    {
        thisenemy = this.gameObject;
        velo = new Vector3(0,0,3f);
        velo2 = new Vector3(0, 0, -3f);
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("PlayerArmature");
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
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
            collided1 = true;
        //}
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collided1 = false;
        }
    }
}

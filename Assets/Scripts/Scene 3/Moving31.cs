using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving31 : MonoBehaviour
{
    float pos1 = 94f;
    float pos2 = 104f;
    Vector3 velo;
    Vector3 velo2;
    Vector3 zero = new Vector3(0f, 0f, 0f);
    Rigidbody rb;
    Collider mycollider;
    Collider playercollider;
    GameObject thisenemy;
    public static GameObject player;
    public static float enemyx = 129f;
    public static float enemyy = 6.41f;
    public static float enemyz = 104f;
    void Start()
    {
        thisenemy = this.gameObject;
        velo = new Vector3(0,0,3f);
        velo2 = new Vector3(0, 0, -3f);
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("PlayerArmature");
        mycollider = GetComponent<SphereCollider>();
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

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = new Vector3(129.1f, 5f, 89.3f);//what we need to do is restore the initial conditions of the enemy
            this.transform.position = new Vector3(enemyx, enemyy, enemyz);
            rb.velocity = zero;
        }
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemycollide : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    GameObject enemy1;
    GameObject enemy2;
    Collider collider1;
    Collider collider2;
    Rigidbody rb1;
    Rigidbody rb2;
    public bool collided1;
    public bool collided2;
    void Start()
    {
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (1)");
        collided1 = enemy1.GetComponent<Moving>().collided1;
        collided2 = enemy2.GetComponent<Moving1>().collided2;
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collided1 || collided2)
        {
            player.transform.position = new Vector3(107.93f, 5f, 80.9f);
            enemy1.transform.position = new Vector3(108f, 6.41f, 87f);
            enemy2.transform.position = new Vector3(108f, 6.41f, 103f);
            rb1.velocity = new Vector3(0, 0, 0);
            rb2.velocity = new Vector3(0, 0, 0);
            collided1 = false;
            collided2 = false;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class ShiftScript3 : MonoBehaviour
{
    Scene current;
    string currentname;
    public static GameObject player;
    public static float positionx;
    public static float positiony;
    public static float positionz;

    public static GameObject enemy1;
    public static float enemy1x;
    public static float enemy1y;
    public static float enemy1z;

    public static GameObject enemy2;
    public static float enemy2x;
    public static float enemy2y;
    public static float enemy2z;

    public static GameObject enemy3;
    public static float enemy3x;
    public static float enemy3y;
    public static float enemy3z;

    public static float enemy1velo;
    public static float enemy2velo;
    public static float enemy3velo;

    Rigidbody rb1;
    Rigidbody rb2;
    Rigidbody rb3;
    public static bool initial = true;
    private void Start()
    {
        if (initial)
        {
            initial = false;
            positionx = 111.98f;
            positiony = 5f;
            positionz = 86.17f;

            enemy1x = 110f;
            enemy1y = 6.41f;
            enemy1z = 110f;

            enemy2x = 106f;
            enemy2y = 6.41f;
            enemy2z = 92f;

            enemy3x = 124f;
            enemy3y = 6.41f;
            enemy3z = 94f;
        }
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere (3)");
        enemy2 = GameObject.Find("Sphere");
        enemy3 = GameObject.Find("Sphere (1)");
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
        enemy3.transform.position = new Vector3(enemy3x, enemy3y, enemy3z);
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
        rb3 = enemy3.GetComponent<Rigidbody>();

        rb1.velocity = new Vector3(enemy1velo, 0, 0);
        rb2.velocity = new Vector3(0, 0, enemy2velo);
        rb3.velocity = new Vector3(enemy3velo, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            enemy1x = enemy1.transform.position.x;
            enemy1y = enemy1.transform.position.y;
            enemy1z = enemy1.transform.position.z;

            enemy2x = enemy2.transform.position.x;
            enemy2y = enemy2.transform.position.y;
            enemy2z = enemy2.transform.position.z;

            enemy3x = enemy3.transform.position.x;
            enemy3y = enemy3.transform.position.y;
            enemy3z = enemy3.transform.position.z;

            enemy1velo = rb1.velocity.x;
            enemy2velo = rb2.velocity.z;
            enemy3velo = rb3.velocity.x;
            if (currentname == "Screen 3 Desert")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;
                SceneManager.LoadScene(6);
            }
            else if (currentname == "Screen 3 Ship")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;
                SceneManager.LoadScene(2);
            }
        }
    }
}

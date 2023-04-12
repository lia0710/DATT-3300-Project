using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class ShiftScript2 : MonoBehaviour
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

    public static float enemy1velo;
    public static float enemy2velo;

    public static bool initial = true;

    Rigidbody rb1;
    Rigidbody rb2;

    private void Start()
    {
        if (initial)
        {
            initial = false;
            positionx = 107.93f;
            positiony = 5f;
            positionz = 80.9f;

            enemy1x = 108f;
            enemy1y = 6.41f;
            enemy1z = 87f;

            enemy2x = 108f;
            enemy2y = 6.41f;
            enemy2z = 103f;
        }
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (1)");
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();

        rb1.velocity = new Vector3(0, 0, enemy1velo);
        rb2.velocity = new Vector3(0, 0, enemy2velo);
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

            enemy1velo = rb1.velocity.z;
            enemy2velo = rb2.velocity.z;

            if (currentname == "Screen 2 Desert")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;

                SceneManager.LoadScene(5);
            }
            else if (currentname == "Screen 2 Ship")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;
                SceneManager.LoadScene(1);
            }
        }
    }
}

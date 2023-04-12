using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class ShiftScript4 : MonoBehaviour
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

    public static GameObject enemy4;
    public static float enemy4x;
    public static float enemy4y;
    public static float enemy4z;

    public static GameObject enemy5;
    public static float enemy5x;
    public static float enemy5y;
    public static float enemy5z;

    public static float enemy1velo;
    public static float enemy2velox;
    public static float enemy2veloz;
    public static float enemy3velox;
    public static float enemy3veloz;
    public static float enemy4velox;
    public static float enemy4veloz;
    public static float enemy5velox;
    public static float enemy5veloz;

    Rigidbody rb1;
    Rigidbody rb2;
    Rigidbody rb3;
    Rigidbody rb4;
    Rigidbody rb5;
    public static bool initial = true;
    private void Start()
    {
        if (initial)
        {
            initial = false;
            positionx = 129.1f;
            positiony = 5f;
            positionz = 89.3f;

            enemy1x = 129f;
            enemy1y = 6.41f;
            enemy1z = 104f;
            
            enemy2x = 113f;
            enemy2y = 6.41f;
            enemy2z = 114f;

            enemy3x = 113f;
            enemy3y = 6.41f;
            enemy3z = 122f;

            enemy4x = 105f;
            enemy4y = 6.41f;
            enemy4z = 114f;

            enemy5x = 105f;
            enemy5y = 6.41f;
            enemy5z = 122f;
        }
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (2)");
        enemy3 = GameObject.Find("Sphere (3)");
        enemy4 = GameObject.Find("Sphere (4)");
        enemy5 = GameObject.Find("Sphere (5)");
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
        enemy3.transform.position = new Vector3(enemy3x, enemy3y, enemy3z);
        enemy4.transform.position = new Vector3(enemy4x, enemy4y, enemy4z);
        enemy5.transform.position = new Vector3(enemy5x, enemy5y, enemy5z);
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
        rb3 = enemy3.GetComponent<Rigidbody>();
        rb4 = enemy4.GetComponent<Rigidbody>();
        rb5 = enemy5.GetComponent<Rigidbody>();

        rb1.velocity = new Vector3(0, 0, enemy1velo);
        rb2.velocity = new Vector3(enemy2velox, 0, enemy2veloz);
        rb3.velocity = new Vector3(enemy3velox, 0, enemy3veloz);
        rb4.velocity = new Vector3(enemy4velox, 0, enemy4veloz);
        rb5.velocity = new Vector3(enemy5velox, 0, enemy5veloz); 
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

            enemy4x = enemy4.transform.position.x;
            enemy4y = enemy4.transform.position.y;
            enemy4z = enemy4.transform.position.z;

            enemy5x = enemy5.transform.position.x;
            enemy5y = enemy5.transform.position.y;
            enemy5z = enemy5.transform.position.z;

            enemy1velo = rb1.velocity.z;
            enemy2velox = rb2.velocity.x;
            enemy2veloz = rb2.velocity.z;
            enemy3velox = rb3.velocity.x;
            enemy3veloz = rb3.velocity.z;
            enemy4velox = rb4.velocity.x;
            enemy4veloz = rb4.velocity.z;
            enemy5velox = rb5.velocity.x;
            enemy5veloz = rb5.velocity.z;
            if (currentname == "Screen 4 Desert")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;
                SceneManager.LoadScene(7);
            }
            else if (currentname == "Screen 4 Ship")
            {
                positionx = player.transform.position.x;
                positiony = player.transform.position.y;
                positionz = player.transform.position.z;
                SceneManager.LoadScene(3);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemycollide2 : MonoBehaviour
{
    // Start is called before the first frame update
    Scene current;
    string currentname;

    public static GameObject player;
    float positionx = 111.98f;
    float positiony = 5f;
    float positionz = 86.17f;

    public static GameObject enemy1;
    float enemy1x = 106f;
    float enemy1y = 6.41f;
    float enemy1z = 92f;

    public static GameObject enemy2;
    float enemy2x = 124f;
    float enemy2y = 6.41f;
    float enemy2z = 94f;

    public static GameObject enemy3;
    float enemy3x = 114f;
    float enemy3y = 6.41f;
    float enemy3z = 102f;

    public static GameObject enemy4;
    float enemy4x = 110f;
    float enemy4y = 6.41f;
    float enemy4z = 110f;

    public static float enemy1velo;
    public static float enemy2velo;
    public static float enemy3velo;
    public static float enemy4velo;

    Rigidbody rb1;
    Rigidbody rb2;
    Rigidbody rb3;
    Rigidbody rb4;

    void Start()
    {
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (1)");
        enemy3 = GameObject.Find("Sphere (2)");
        enemy4 = GameObject.Find("Sphere (3)");
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
        rb3 = enemy3.GetComponent<Rigidbody>();
        rb4 = enemy4.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        rb1.velocity = new Vector3(0, 0, 0);
        rb2.velocity = new Vector3(0, 0, 0);
        rb3.velocity = new Vector3(0, 0, 0);
        rb4.velocity = new Vector3(0, 0, 0);
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
        enemy3.transform.position = new Vector3(enemy3x, enemy3y, enemy3z);
        enemy4.transform.position = new Vector3(enemy4x, enemy4y, enemy4z);
    }


}

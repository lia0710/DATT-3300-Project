using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemycollide3 : MonoBehaviour
{
    // Start is called before the first frame update
    Scene current;
    string currentname;

    public static GameObject player;
    float positionx = 129.1f;
    float positiony = 5f;
    float positionz = 89.3f;

    public static GameObject enemy1;
    float enemy1x = 129f;
    float enemy1y = 6.41f;
    float enemy1z = 104f;

    public static GameObject enemy2;
    float enemy2x = 129f;
    float enemy2y = 6.41f;
    float enemy2z = 117.97f;

    public static GameObject enemy3;
    float enemy3x = 113f;
    float enemy3y = 6.41f;
    float enemy3z = 114f;

    public static GameObject enemy4;
    float enemy4x = 113f;
    float enemy4y = 6.41f;
    float enemy4z = 122f;

    public static GameObject enemy5;
    float enemy5x = 105f;
    float enemy5y = 6.41f;
    float enemy5z = 114f;

    public static GameObject enemy6;
    float enemy6x = 105f;
    float enemy6y = 6.41f;
    float enemy6z = 122f;

    public static float enemy1velo;
    public static float enemy2velo;
    public static float enemy3velo;
    public static float enemy4velo;
    public static float enemy5velo;
    public static float enemy6velo;

    Rigidbody rb1;
    Rigidbody rb2;
    Rigidbody rb3;
    Rigidbody rb4;
    Rigidbody rb5;
    Rigidbody rb6;

    void Start()
    {
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (1)");
        enemy3 = GameObject.Find("Sphere (2)");
        enemy4 = GameObject.Find("Sphere (3)");
        enemy5 = GameObject.Find("Sphere (4)");
        enemy6 = GameObject.Find("Sphere (5)");
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
        rb3 = enemy3.GetComponent<Rigidbody>();
        rb4 = enemy4.GetComponent<Rigidbody>();
        rb5 = enemy5.GetComponent<Rigidbody>();
        rb6 = enemy6.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        rb1.velocity = new Vector3(0, 0, 0);
        rb2.velocity = new Vector3(0, 0, 0);
        rb3.velocity = new Vector3(0, 0, 0);
        rb4.velocity = new Vector3(0, 0, 0);
        rb5.velocity = new Vector3(0, 0, 0);
        rb6.velocity = new Vector3(0, 0, 0);
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
        enemy3.transform.position = new Vector3(enemy3x, enemy3y, enemy3z);
        enemy4.transform.position = new Vector3(enemy4x, enemy4y, enemy4z);
        enemy5.transform.position = new Vector3(enemy5x, enemy5y, enemy5z);
        enemy6.transform.position = new Vector3(enemy6x, enemy6y, enemy6z);
    }


}

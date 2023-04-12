using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemycollide1 : MonoBehaviour
{
    // Start is called before the first frame update
    Scene current;
    string currentname;

    public static GameObject player;
    float positionx = 107.93f;
    float positiony = 5f;
    float positionz = 80.9f;

    public static GameObject enemy1;
    float enemy1x = 108f;
    float enemy1y = 6.41f;
    float enemy1z = 87f;

    public static GameObject enemy2;
    float enemy2x = 108f;
    float enemy2y = 6.41f;
    float enemy2z = 103f;

    public static float enemy1velo;
    public static float enemy2velo;

    Rigidbody rb1;
    Rigidbody rb2;

    void Start()
    {
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        enemy1 = GameObject.Find("Sphere");
        enemy2 = GameObject.Find("Sphere (1)");
        rb1 = enemy1.GetComponent<Rigidbody>();
        rb2 = enemy2.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        rb1.velocity = new Vector3(0, 0, 0);
        rb2.velocity = new Vector3(0, 0, 0);
        player.transform.position = new Vector3(positionx, positiony, positionz);
        enemy1.transform.position = new Vector3(enemy1x, enemy1y, enemy1z);
        enemy2.transform.position = new Vector3(enemy2x, enemy2y, enemy2z);
    }


}

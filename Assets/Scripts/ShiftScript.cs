using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShiftScript : MonoBehaviour
{
    Scene current;
    string currentname;
    GameObject player;
    public static float positionx = 106.15f;
    public static float positiony = 5f;
    public static float positionz = 86.17f;
    private void Start()
    {
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        player.transform.position = new Vector3(positionx, positiony, positionz);
    }
    // Update is called once per frame
    void Update()
    {
        positionx = player.transform.position.x;
        positiony = player.transform.position.y;
        positionz = player.transform.position.z;
        if (Input.GetKeyDown("space"))
        {
            //print(currentname);
            if (currentname == "Screen 1 Desert")
            {
                SceneManager.LoadScene(4);
            }
            else if (currentname == "Screen 1 Ship")
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class OnLevelShift1 : MonoBehaviour
{
    // Start is called before the first frame update
    Scene current;
    string currentname;
    GameObject player;
    GameObject mycamera;
    float positionx;
    float positiony;
    float positionz;
    float campositionx;
    float campositiony;
    float campositionz;

    private void Start()
    {
        current = SceneManager.GetActiveScene();
        currentname = current.name;
        player = GameObject.Find("PlayerArmature");
        mycamera = GameObject.Find("MainCamera");
    }
    // Update is called once per frame
    void Update()
    {
        positionx = player.transform.position.x;
        positiony = player.transform.position.y;
        positionz = player.transform.position.z;
        campositionx = mycamera.transform.position.x;
        campositiony = mycamera.transform.position.y;
        campositionz = mycamera.transform.position.z;

        if (Input.GetKeyDown("e"))
        {
            if (positionx >= -500)
            {
                print(">500");
                positionx -= 1000f;
                campositionx -= 1000f;
            }
            else
            {
                print("<500");
                positionx += 1000f;
                campositionx += 1000f;
            }
            
        }
        player.transform.position = new Vector3(positionx, positiony, positionz);
        mycamera.transform.position = new Vector3(campositionx, campositiony, campositionz);
    }
}

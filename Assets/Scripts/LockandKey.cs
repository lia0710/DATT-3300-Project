using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockandKey : MonoBehaviour
{
    GameObject keycube;
    GameObject lockcube;
    public static bool state = true;
    void Start()
    {
        keycube = GameObject.Find("Key Cube");
        lockcube = GameObject.Find("Lock Cube");
    }

    private void Update()
    {
        keycube.SetActive(state);
        lockcube.SetActive(state);
    }

    private void OnTriggerEnter(Collider other)
    {
        state = false;
    }
}

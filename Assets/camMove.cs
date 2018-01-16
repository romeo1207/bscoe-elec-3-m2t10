using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{

    GameObject rocket;
    Vector3 cameraOffset;

    void Start()
    {
        rocket = GameObject.Find("Player");
        cameraOffset = new Vector3(0, 1, -30);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rocket.transform.position + cameraOffset;
    }
}

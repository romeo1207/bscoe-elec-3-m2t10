using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	Rigidbody _rigidbody;

	void Start () {
        _rigidbody = GetComponent<Rigidbody>();
            }
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddRelativeForce(Vector3.up * 50);
            print("fly");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 3);
            print("left");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward *3);
            print("right");
        }
    }
}

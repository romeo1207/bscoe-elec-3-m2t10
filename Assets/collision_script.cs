using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_script : MonoBehaviour {

	// Use this for initialization
	bool showMessage = false;
    float timeDisplay = 3.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
    {
    	if (collision.gameObject.tag == "Initial Position") {
    		Debug.Log("Racket Ship is in Initial State.");
    		showMessage = false;
    	}

        else if (collision.gameObject.tag == "Target Pad")
        {
            Debug.Log("TARGET REACHED.");
 			showMessage = true;
        }
        else
        {
        	Application.LoadLevel(Application.loadedLevel);
            Debug.Log("COLLIDE");
        }
    }

    void OnGUI () {
    	if (showMessage) {
    		GUI.color = Color.yellow;
    		GUI.Label(new Rect(100, Screen.height/2-25, Screen.width, 50), "CONGRATULATIONS!\nYou completed the challenge.");
    	}
    }
}

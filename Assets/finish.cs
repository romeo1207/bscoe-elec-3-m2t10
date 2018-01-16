using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour {

	Material material;
		void Start(){
			material = GetComponent<Renderer>().material;
		}
	
	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Player")
		{
			Debug.Log("Collided with finish!");
			material.color = Color.red;
		}
	}
}

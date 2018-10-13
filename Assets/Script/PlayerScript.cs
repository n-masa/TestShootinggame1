using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour {

	public float speed; //速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed, transform.position.y + Input.GetAxis("Vertical") * speed, 0);
	}
}

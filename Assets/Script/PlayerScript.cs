using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int speed; //速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal"), transform.position.y + Input.GetAxis("Vertical"), 0);
	}
}

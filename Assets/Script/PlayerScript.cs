using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour {

	public float maxspeed; //速度
	public float lowspeed; //低速移動速度

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	//移動用関数
	void Move(){
		float MoveX =  Input.GetAxisRaw("Horizontal");
		float MoveY = Input.GetAxisRaw("Vertical");
		Vector2 Dir = new Vector2(MoveX, MoveY).normalized;
		float MoveSpeed;
		if(Input.GetKey(KeyCode.LeftShift))
		{
			MoveSpeed = lowspeed;
		}else{
			MoveSpeed = maxspeed;
		}
		GetComponent<Rigidbody2D>().velocity = Dir * MoveSpeed;
	}
}

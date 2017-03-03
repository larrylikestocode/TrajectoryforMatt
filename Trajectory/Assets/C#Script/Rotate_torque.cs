using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_torque : MonoBehaviour {

  public float amount = 50f;

	public Rigidbody rb;
	void start(){

		rb=GetComponent<Rigidbody>(); 
	
	}

	// Update is called once per frame
	void FixedUpdate ()

	{
		float h= Input.GetAxis("Horizontal")*amount*Time.deltaTime;
		float v= Input.GetAxis("Vertical")*amount*Time.deltaTime;

		if(Input.GetKey(KeyCode.UpArrow))
			rb.AddTorque(transform.up * h);
		if(Input.GetKey(KeyCode.LeftArrow))
			rb.AddTorque(transform.right * v);



	}
}
  
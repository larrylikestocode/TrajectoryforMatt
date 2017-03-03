using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FORCE : MonoBehaviour 
{
	public float tra_Force;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void OnMouseDown()
	{
		rb.AddForce(Vector3.right * tra_Force, ForceMode.Acceleration);
	
	}



}

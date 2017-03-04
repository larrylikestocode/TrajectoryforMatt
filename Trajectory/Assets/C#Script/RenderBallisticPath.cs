using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderBallisticPath : MonoBehaviour {

	public float initialVelocity = 10.0f;
	public float timerResolution = 0.02f;
	public float maxTime = 10.0f;

	private LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 

	{
		Vector3 velocityVector = transform.forward * initialVelocity;
		Vector3 currentPosition = transform.position;
		int index = 0; 

		lineRenderer.numPositions =(int)(maxTime/timerResolution);


		for (float t = 0.0f; t < maxTime; t += timerResolution) 
		{
			lineRenderer.SetPosition(index,currentPosition);
			currentPosition+=velocityVector*timerResolution;
			velocityVector += Physics.gravity*timerResolution;
			index++;
		}



	}
}

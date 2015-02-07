using UnityEngine;
using System.Collections;

public class BasicObjectPlacement : MonoBehaviour {

	private GameObject newTarget;
	private float randomZRotation = 1.0f;

	void Awake()
	{
		randomZRotation = Random.Range(0, 360);
		transform.Rotate(0,randomZRotation, 0);
	}


	void Update () 
	{
		

	}
}
	
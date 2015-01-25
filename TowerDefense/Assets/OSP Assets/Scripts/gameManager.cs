﻿using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour
{
	public LayerMask PlaceLayer;
	Vector3 TargetPosition;
	Vector3 TouchPosition;
	public GameObject Hero;

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log("Press");
			RaycastHit hit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(), out hit, Mathf.Infinity, PlaceLayer))
			{
				Instantiate(Hero, hit.point, Hero.transform.rotation);
			}
		}
	}
	void OnTouchBeganAnyWhere()
	{

	}

}

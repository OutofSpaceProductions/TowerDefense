using UnityEngine;
using System.Collections;

public class girdControl : MonoBehaviour {

	public Material MouseOver;
	public Material Taken;
	public Material Open;

	bool taken = false;
	bool mouseOver = false;

	public LayerMask Grid;

	void Start () 
	{
		renderer.material = Open;
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit, Mathf.Infinity, Grid))
		{
			renderer.material = MouseOver;
		}
		else
		{
			renderer.material = Open;
			return;
		}
	}
	void OnMouseDown()
	{
		renderer.material = Taken;
	}
}

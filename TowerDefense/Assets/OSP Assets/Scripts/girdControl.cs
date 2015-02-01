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
	void OnMouseOver () 
	{
		renderer.material = MouseOver;
	}
	void OnMouseDown()
	{
		Debug.Log("Material is Taken");
		renderer.material = Taken;
	}
}

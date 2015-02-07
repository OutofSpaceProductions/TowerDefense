using UnityEngine;
using System.Collections;

public class TankScript : MonoBehaviour {

	AI aiScript;

	Animator anim;

	void Start () 
	{
		aiScript = gameObject.GetComponent<AI>();
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(aiScript._ReachedTarget == true)
		{
			Attack();
		}
		else
		{
			return;
		}
	}
	void Attack()
	{
		Debug.Log("Attacking" + this.gameObject.name);
		anim.SetBool("Attacking", true);
	}
}

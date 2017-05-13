using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFFManager : MonoBehaviour
{

	public static FFFManager fm;
	public GameObject FFF;
	public Transform player;
	public float generateTime = 2;

	float myTime;

	void Awake ()
	{
		fm = this;
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		myTime += Time.deltaTime;
		if (myTime >= generateTime) {

			Vector2 r = Random.insideUnitCircle.normalized * 20;

			Instantiate (FFF, player.position + new Vector3 (r.x, 0, r.y), Quaternion.Euler (new Vector3 (0, Random.Range (0.0f, 360.0f), 0)));
			myTime = 0;
		}
	}
}

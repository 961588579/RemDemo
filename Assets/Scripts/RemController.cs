using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemController : MonoBehaviour
{

	public float rotateSpeed = 120;
	public float moveSpeed = 6;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward * Time.deltaTime * moveSpeed;
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up * Time.deltaTime * -rotateSpeed);
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * rotateSpeed);
		}
	}
}

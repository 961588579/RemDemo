using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFFController : MonoBehaviour
{
	public float rotationSpeed = 6;
	public float moveSpeed = 6;
	public GameObject blood;

	Transform player;

	// Use this for initialization
	void Start ()
	{
		player = FFFManager.fm.player;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 targetDir = player.position - transform.position;
		float step = rotationSpeed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0f);
		transform.rotation = Quaternion.LookRotation (newDir);

		transform.Translate (Vector3.forward * Time.deltaTime * moveSpeed);
	}

	public void Hurt ()
	{
		Destroy (gameObject);
		Instantiate (blood, transform.position, Quaternion.identity);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "FFF") {
			col.GetComponent<FFFController> ().Hurt ();
		}
	}
}

using UnityEngine;
using System.Collections;

public class BloodDestory : MonoBehaviour
{
	public float delayTime = 5;

	// Use this for initialization
	void Start ()
	{
		Destroy (gameObject, delayTime);
	}

}


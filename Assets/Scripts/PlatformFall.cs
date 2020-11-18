using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
	public float fallTime = 0.5f;

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("What have I collided with? " + collision.gameObject.name);
		if (collision.gameObject.tag == "Player")
		{
			Debug.Log("Collided sucessfully");
			Invoke("Fall", fallTime);
			//StartCoroutine(Fall(fallTime));
		}
	}

	// add setactive true when falling through level collider

	void Fall()
	{
		gameObject.SetActive(false);
		//Destroy(gameObject);
	}
}

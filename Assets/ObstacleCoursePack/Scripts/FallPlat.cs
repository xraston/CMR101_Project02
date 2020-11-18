using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlat : MonoBehaviour
{
	public float fallTime = 0.5f;


	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("What have I collided with? " + collision.gameObject.name);
			if (collision.gameObject.name.Equals("XRRig"))
			{
				StartCoroutine(Fall(fallTime));
				Debug.Log("Collided sucessfully");
		}
	}

	IEnumerator Fall(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}
}

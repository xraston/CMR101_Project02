using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
	public float dissapearTime;
	public int reappearTime;

	void OnCollisionEnter(Collision collision)
	{
		Invoke("Fall", dissapearTime);
		Invoke("ResetPlatform", reappearTime);
		
	}

	public void Fall()
	{
		gameObject.SetActive(false);
		//Destroy(gameObject);
	}

	public void ResetPlatform()
	{
		gameObject.SetActive(true);
		//Destroy(gameObject);
	}
}

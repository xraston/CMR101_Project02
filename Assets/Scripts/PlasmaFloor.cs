﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaFloor : MonoBehaviour
{
	public Vector3 checkPoint;
	public GameObject XRRig;
	// public PlatformFall platformFall;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
        {
			XRRig.transform.position = checkPoint;
			// platformFall.ResetPlatform();
		}
	}
}

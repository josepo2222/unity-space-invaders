﻿using UnityEngine;
using System.Collections;

public class BarrerBlockBroke : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary")
		{
			return;
		}
		if (other.tag == "Beam") 
			Destroy(other.gameObject.transform.parent.gameObject);
		Destroy(gameObject);
	}
}

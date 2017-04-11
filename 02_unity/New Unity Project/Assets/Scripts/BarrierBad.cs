using UnityEngine;
using System.Collections;

public class BarrierBad : MonoBehaviour {
	public GameObject Red;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary")
		if (other.tag == "Green")	
		if (other.tag == "Orange")
		if (other.tag == "Red")
		{
			return;
		}
		if (other.tag == "Beam")
			Instantiate(Red, transform.position, transform.rotation);
		Destroy(other.gameObject.transform.parent.gameObject);
		Destroy(gameObject);
	}
}

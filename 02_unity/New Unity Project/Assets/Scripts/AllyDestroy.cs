using UnityEngine;
using System.Collections;

public class AllyDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary")
		{
			return;
		}
		if (other.tag == "Tank") 
			Destroy(other.gameObject);
	}
}

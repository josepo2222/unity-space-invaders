using UnityEngine;
using System.Collections;

public class EnemyShotDestroy : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Alien")	
		{
			return;
		}
		if (other.tag == "Tank")	
			Destroy(other.gameObject.transform.parent.gameObject);
		Destroy(gameObject);
	}
}

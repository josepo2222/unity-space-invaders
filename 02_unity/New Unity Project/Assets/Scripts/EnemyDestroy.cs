using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour{

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Boundary")
		{
			return;
		}
		if (other.tag == "Alien") 
			Destroy(other.gameObject);
		Destroy(gameObject);
	}
}

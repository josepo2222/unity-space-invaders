using UnityEngine;
using System.Collections;

public class ShotBoundary : MonoBehaviour 
{
	void OnTriggerExit(Collider other) 
	{
		Destroy(other.gameObject.transform.parent.gameObject);
	}
}

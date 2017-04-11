using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour 
{
		public float speed;
		void Start ()
		{
		GetComponent<Rigidbody> ().velocity = transform.up * speed;
		}
	}
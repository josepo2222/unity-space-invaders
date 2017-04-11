using UnityEngine;
using System.Collections;

public class Tankshot : MonoBehaviour {

	public GameObject Shot;
	public Transform ShotSpawn;
	public float fireRate;

	private float nextFire;

	void Update ()
	{
		if (Input.GetButton ("Jump") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
		}
	}
}
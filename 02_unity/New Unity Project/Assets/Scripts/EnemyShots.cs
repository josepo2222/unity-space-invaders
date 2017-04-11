using UnityEngine;
using System.Collections;

public class EnemyShots : MonoBehaviour {

	public GameObject Shot;
	public Transform BulletSpawn;
	public float startWait;
	public float fireRate;
	private float nextFire;

	void Start ()
	{
		StartCoroutine (FireShot ());
	}

	IEnumerator FireShot ()
	{
		yield return new  WaitForSeconds (startWait);
		while (true)
		{
			if (Time.time > nextFire) {
				nextFire = Time.time + fireRate;
				Instantiate (Shot, BulletSpawn.position, BulletSpawn.rotation);
				yield return new  WaitForSeconds (fireRate);
			}
		}
	}
}
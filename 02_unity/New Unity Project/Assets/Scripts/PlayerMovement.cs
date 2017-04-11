using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}
	
public class PlayerMovement : MonoBehaviour 
{
	public float speed;

	public Boundary boundary;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		var movement = new Vector2 (moveHorizontal, 0.0f);
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = movement * speed;

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp (rigidbody.position.y,boundary.yMin, boundary.yMax),
				4.0f

			);
	} 
}

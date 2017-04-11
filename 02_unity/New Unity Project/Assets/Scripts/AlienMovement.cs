using UnityEngine;
using System.Collections;

public class AlienMovement : MonoBehaviour {	
	public Transform[] Waypoints;
	public float Speed;
	public int curWaypoint;
	public bool Patrol = true;
	public Vector3 Target;
	public Vector3 MoveDirection;
	public Vector3 Velocity;
	public float pauseDuration = 0;

	private float curTime;

	void Update () 

	{
		if(curWaypoint < Waypoints.Length)
		{
			Target = Waypoints[curWaypoint].position;
			MoveDirection = Target - transform.position;
			Velocity = GetComponent<Rigidbody>().velocity;

			if(MoveDirection.magnitude < 1){
				if (curTime == 0)
					curTime = Time.time;
				if ((Time.time - curTime) >= pauseDuration) {
					curWaypoint++;
					curTime = 0;
				}
			}
			else
			{
				Velocity = MoveDirection.normalized * Speed;
			}
		}

		else
		{
			if(Patrol)
			{
				curWaypoint=0;
			}
			else
			{
				Velocity = Vector3.zero;
			}
		}
		GetComponent<Rigidbody>().velocity = Velocity;
	}
}
	
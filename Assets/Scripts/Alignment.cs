using UnityEngine;
using System.Collections;

public class Alignment : FlockingBehavior 
{
	public override Vector3 Acceleration
	{
		get
		{
			Vector3 velocitoid = Vector3.zero;
			
			foreach(GameObject neighbour in Neighbours)
			{
				velocitoid += neighbour.GetComponent<MovementAgent>().Velocity;
			}
			
			velocitoid /= Neighbours.Count;

			return MaxAcceleration * velocitoid.normalized;
		}
	}
}

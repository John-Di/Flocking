using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Separation : FlockingBehavior 
{
	public List<GameObject> highAvoidance;

	public override Vector3 Acceleration
	{
		get
		{
			Vector3 centroid = Vector3.zero;
			
			foreach(GameObject neighbour in Neighbours)
			{
					centroid += neighbour.transform.position;
			}			
			
			centroid /= Neighbours.Count;
			
			Vector3 directionVec = transform.position - centroid;
			Vector3 steeringAccel = MaxAcceleration * directionVec.normalized;
			
			
			return steeringAccel;
		}
	}
}

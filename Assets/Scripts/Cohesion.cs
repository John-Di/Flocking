using UnityEngine;
using System.Collections;

public class Cohesion : FlockingBehavior 
{	
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
			
			Vector3 directionVec = centroid - transform.position;
			Vector3 steeringAccel = MaxAcceleration * directionVec.normalized;
			
			return steeringAccel;

			return Vector3.zero;
		}
	}
}

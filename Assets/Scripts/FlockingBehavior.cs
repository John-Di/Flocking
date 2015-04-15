using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class FlockingBehavior : MovementBehavior 
{	
	public float radius;	
	
	public List<GameObject> Neighbours
	{
		get
		{
			List<GameObject> neighbors = new List<GameObject>();

			foreach(GameObject bug in GameObject.FindGameObjectsWithTag(tag))
			{
				if((transform.position - bug.transform.position).magnitude <= radius)
				{
					neighbors.Add(bug);
				}
			}

			neighbors.Remove(gameObject);

			return neighbors;
		}
	}
}

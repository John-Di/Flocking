using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MovementAgent))]
public abstract class MovementBehavior : MonoBehaviour 
{
	public float MaxAcceleration;
	public float MaxAngularAcceleration;
	
	public virtual Vector3 Acceleration
	{
		get
		{
			return Vector3.zero;
		}
	}
}

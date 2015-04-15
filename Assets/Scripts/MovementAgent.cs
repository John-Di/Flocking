using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public sealed class MovementAgent : MonoBehaviour 
{
	public float MaxVelocity;
	public float MaxAngularVelocity;
	
	public Vector3 Velocity { get; private set; }
	public float AngularVelocity { get; private set; }
	
	List<MovementBehavior> behaviors;
	
	void Start()
	{
		behaviors = GetComponents<MovementBehavior>().ToList();
		Velocity = new Vector3(Random.Range(-1f,1f),0f,Random.Range(-1f,1f) * MaxVelocity);
	}
	
	void FixedUpdate()
	{
		UpdateVelocities(Time.deltaTime);
		
		UpdatePosition(Time.deltaTime);
		UpdateRotation(Time.deltaTime);
	}
	
	public void ResetVelocities()
	{
		Velocity = Vector3.zero;
		AngularVelocity = 0f;
	}
	
	private void UpdateVelocities(float deltaTime)
	{
		foreach(MovementBehavior b in behaviors)
		{
			Velocity += b.Acceleration * deltaTime;
		}
		
		Velocity = (Velocity.magnitude < MaxVelocity) ? Velocity : Velocity.normalized * MaxVelocity;
		
		Velocity = new Vector3(Velocity.x, 0.0f, Velocity.z);
		
	}
	
	private void UpdatePosition(float deltaTime)
	{
		transform.position += Velocity * deltaTime;
	}
	
	private void UpdateRotation(float deltaTime)
	{
		if(Velocity.sqrMagnitude > 0f)
			transform.rotation = Quaternion.LookRotation(Velocity.normalized, Vector3.up);
	}
}

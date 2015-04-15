using UnityEngine;
using System.Collections;

public abstract class SteeringBehavior : MovementBehavior 
{
	
	public virtual float AngularAcceleration
	{
		get
		{
			return 0f;
		}
	}

	public virtual bool HaltTranslation
	{
		get
		{
			return false;
		}
	}
	
	public virtual bool HaltRotation
	{
		get
		{
			return false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Wrap : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerExit(Collider obj)
	{
		float offset = 50f;

		if(Mathf.Abs(obj.transform.position.x) > 150f)
		{
			obj.transform.position = new Vector3(-(obj.transform.position.x + offset/500f), obj.transform.position.y, obj.transform.position.z);
		}

		if(Mathf.Abs(obj.transform.position.z) > 150f)
		{
			obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, -(obj.transform.position.z + offset));
		}
	}
}

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
	public GameObject prefab;
	public int MAX_SPAWN;
	float spawnerTimer = 0f;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameObject.FindGameObjectsWithTag(prefab.tag).Length < MAX_SPAWN)
		{
			spawnerTimer -= Time.deltaTime;

			if(spawnerTimer <= 0f)
			{
				GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
				spawnerTimer = 0.5f;
			}
		}
		else if(GameObject.FindGameObjectsWithTag(prefab.tag).Length == MAX_SPAWN && spawnerTimer >= 0f)
		{
			foreach(GameObject obj in GameObject.FindGameObjectsWithTag(prefab.tag))
			{
				Destroy(obj, 60f);
			}

			spawnerTimer = 0f;
		}
	}
}

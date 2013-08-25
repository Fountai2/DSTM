using UnityEngine;
using System.Collections;

public class DeathHandler : MonoBehaviour {
	
	//variables, duh.
	
	public int deathCount;
	public Vector3 playerStart;
	public int checkPoint;
			
			
	// Use this for initialization
	void Start () 
	{
	deathCount = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	
	void OnTriggerEnter(Collider other)
	{
	Debug.Log ("Collision");
		if (other.gameObject.tag == "deathObject"){
		deathCount += 1;
		}
	/**if(hit.gameObject.tag==deathCount)
		{
			Debug.Log ("Add 1 to DeathCount");
		}**/
		
	}
	
}

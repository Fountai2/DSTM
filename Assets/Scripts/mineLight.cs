using UnityEngine;
using System.Collections;

public class mineLight : MonoBehaviour {
	public bool lightBright;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (lightBright == false)
		{
		light.range += .2f;	
			if (light.range >=10)
			{
				lightBright =true;
			}
		}
		
	if (lightBright == true) 
		{
			light.range -=.2f;
			if(light.range <=1)
			{
			lightBright=false;	
			}
		}
	
			
	}
}

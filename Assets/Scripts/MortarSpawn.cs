using UnityEngine;
using System.Collections;

public class MortarSpawn : MonoBehaviour {
	GameObject mortarSpawnTimer;
	public float currentTime;
	public float setDropTime;
	public GameObject mortar;
	float lastfired =0;
	bool dropped;
	public bool repeat;
	// Use this for initialization
	void Start () {
	dropped =false;
	mortarSpawnTimer = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () {
	Score Score = mortarSpawnTimer.GetComponentInChildren<Score>();
		currentTime = Score.timer;
		
		if (currentTime >= setDropTime && dropped != true)
		{
		dropped = true;
		Instantiate (mortar, this.transform.position, Quaternion.identity);	
		}
		if (repeat == true && dropped == true && Time.time >= lastfired +2f && currentTime >= (setDropTime+3.5))
		{
			lastfired = Time.time;
			Instantiate (mortar, this.transform.position, Quaternion.identity);		
		}
	}
}

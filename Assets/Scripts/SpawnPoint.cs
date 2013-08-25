using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {
	public int id;
	public Vector3 SpawnPos;
	// Use this for initialization
	void Start () {
	SpawnPos=this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

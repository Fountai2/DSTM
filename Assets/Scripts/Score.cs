using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int score;
	public UILabel scoreLabel;
	public UILabel timeLabel;
	GameObject simplePlayer;
	public float timer;
	
	
	// Use this for initialization
	void Start () {
	 simplePlayer = GameObject.Find("SimplePlayer");
	
	}
	
	// Update is called once per frame
	void Update () {
	timer += Time.deltaTime;
		vp_DamageHandler vp_DamageHandler = simplePlayer.GetComponent<vp_DamageHandler>();
		score = vp_DamageHandler.deathCount;
		scoreLabel.text = score.ToString();
		timeLabel.text = timer.ToString();
}
}

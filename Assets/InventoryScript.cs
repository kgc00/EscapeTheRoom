using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

	public int blueScore = 0;
	public int redScore = 0;
	public int greenScore = 0;

	public float timeLeft;
	public Text timerTextUI;

	private float minutes;
	private float seconds;

	// Use this for initialization
	void Start () {
		blueScore = 0;
		redScore = 0;
		greenScore = 0;
		timeLeft = 600.0f;

	}
	
	// Update is called once per frame
	void Update () {

		if (timeLeft >= 0) {
			timeLeft = timeLeft - Time.deltaTime;
			timerTextUI.text = "Time Left:" + Mathf.Round (timeLeft);
		}
	}
}

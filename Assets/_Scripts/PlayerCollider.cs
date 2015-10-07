﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public Text scoreLabel;
	public Text livesLabel;
	public int  scoreValue = 0;
	public int  livesValue = 5;

	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources; // an array of AudioSources
	private AudioSource _cloudAudioSource, _islandAudioSource, _endAudioSource, _livesAudioSource;

	private HighScoreController _highScoreController;


	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._cloudAudioSource = this._audioSources [1];
		this._islandAudioSource = this._audioSources [2];
		this._endAudioSource = this._audioSources [3];
		this._livesAudioSource = this._audioSources [4];

		this._highScoreController = GameObject.FindWithTag ("HighScoreController").GetComponent ("HighScoreController") as HighScoreController;

		this._SetScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D otherGameObject) {
		if (otherGameObject.tag == "Island") {
			this._islandAudioSource.Play (); // play yay sound
			this.scoreValue += 100; // add 100 points
			if((this.scoreValue % 1000) == 0) {
				this._livesAudioSource.Play();
				this.livesValue++;
			}
		}
		if (otherGameObject.tag == "Cloud") {
			this._cloudAudioSource.Play (); // play thunder sound
			this.livesValue--; // remove one life
			if(this.livesValue <= 0) {
				this._EndGame();
			}
		}
		this._SetScore ();
	}

	// PRIVATE METHODS
	private void _SetScore() {
		this.scoreLabel.text = "Score: " + this.scoreValue;
		this.livesLabel.text = "Lives: " + this.livesValue;
	}

	private void _EndGame() {
		this._highScoreController.finalScore = this.scoreValue; // passing scoreValue to finalScore
		Application.LoadLevel ("GameOver");
	}
	
}

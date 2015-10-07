using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Text finalScoreLabel;

	// PRIVATE INSTANCE VARIABLES
	private HighScoreController _highScoreController;

	// Use this for initialization
	void Start () {
		this._highScoreController = GameObject.FindWithTag ("HighScoreController").GetComponent ("HighScoreController") as HighScoreController;
		this.finalScoreLabel.text = "Score: " + this._highScoreController.finalScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Restart Button Event Handler
	public void OnRestartButtonClick() {
		Application.LoadLevel ("Main");
	}
}

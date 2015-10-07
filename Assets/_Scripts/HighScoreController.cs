using UnityEngine;
using System.Collections;

public class HighScoreController : MonoBehaviour {
	public int finalScore;

	void Awake() {
		DontDestroyOnLoad (this);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int cloudCount;
	public GameObject cloud;
	
	// Use this for initialization
	void Start () {
		this._GenerateClouds ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// generate Clouds
	private void _GenerateClouds() {
		for (int count=0; count < this.cloudCount; count++) {
			Instantiate(cloud);
		}
	}
}

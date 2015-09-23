using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++
	public Vector2 move = new Vector2 (0.0f, 0.0f);
	
	// PRIVATE INSTANCE VARIABLES
	private Vector2 newPosition = new Vector2(0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		Debug.Log ("Player entered the scene");
	}
	
	// Update is called once per frame
	void Update () {
		newPosition = gameObject.GetComponent<Transform> ().position; // current position
		
		if (Input.GetAxis ("Horizontal") > 0) {
			newPosition.x += this.move.x; // add move value to current position
			gameObject.GetComponent<Transform>().position = newPosition;
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			newPosition.x -= this.move.x; // subtract move value to current position
			gameObject.GetComponent<Transform>().position = newPosition;
		}
		
		if (Input.GetAxis ("Vertical") > 0) {
			newPosition.y += this.move.y; // add move value to current position
			gameObject.GetComponent<Transform>().position = newPosition;
		}
		if (Input.GetAxis ("Vertical") < 0) {
			newPosition.y -= this.move.y; // subtract move value to current position
			gameObject.GetComponent<Transform>().position = newPosition;
		}
	}
}

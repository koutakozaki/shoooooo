using UnityEngine;
using System.Collections;
public class pla : MonoBehaviour {
	public Vector2 SPEED = new Vector2(0.1f,0.1f);

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		Move ();
	}

	void Move(){
		Vector2 Position = transform.position;
		if (Input.GetKey ("up")) {
			Position.y += SPEED.y;
		} else if (Input.GetKey ("down")) {
			Position.y -= SPEED.y;
		}
		transform.position = Position;
	}
}
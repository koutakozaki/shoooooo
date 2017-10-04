using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour {
	public Vector2 speed = new Vector2 (0.25f, 0.25f);
	public player targetObject;
	private float rad;
	private Vector2 Position;
	// Use this for initialization
	void Start () {
		rad = Mathf.Atan2 (
			targetObject.transform.position.y - transform.position.y,
			targetObject.transform.position.x - transform.position.x);
	}
	
	// Update is called once per frame
	void Update () {
		Position = transform.position;
		Position.x += speed.x * Mathf.Cos (rad);
		Position.y += speed.y * Mathf.Sin (rad);
		transform.position = Position;
		
	}
}
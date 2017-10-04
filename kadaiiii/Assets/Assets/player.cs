using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public GameObject beam;
    public static int count;
    int frame;


	// Use this for initialization
	void Start () {
        frame = 0;
        count = 30;
		
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if(Input.GetKey(KeyCode.Z)&& frame % count == 0){
            Instantiate(beam,new Vector2(transform.position.x,transform.position.y),Quaternion.identity);}
    }
}
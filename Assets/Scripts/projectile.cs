using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    public float speed;
    public Rigidbody2D rgBody;
    public GameObject player;
    public int direction;

	// Use this for initialization
	void Start () {
        rgBody.AddForce(new Vector2(speed * direction, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

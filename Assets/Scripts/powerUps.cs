using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour {


	// Use this for initialization
	void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<playerScript>().points++;
            Destroy(this.gameObject);

        }
    }
}

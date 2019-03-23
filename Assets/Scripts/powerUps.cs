using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour {

    public int point;
    public Sprite frame1, frame2;
    private float frameRates;

	// Use this for initialization
	void Start () {
      

    }
	
	// Update is called once per frame
	void Update () {
        if (frameRates < 0){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<SpriteRenderer>().sprite ? frame1 : frame2;
            frameRates = 1;


        }else{
            frameRates -= Time.deltaTime;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<playerScript>().points += point;
            Destroy(this.transform.parent.gameObject);

        }
    }
}

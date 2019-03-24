using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour {

    public int point;
    private SpriteRenderer spr;
    public Sprite[] sprites;
    private float frameCoolDown;

    // Use this for initialization
    void Start () {
        spr = transform.parent.gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        frameCoolDown -= Time.deltaTime;
        if (frameCoolDown < 0)
        {
            frameCoolDown = 0.5f;
            spr.sprite = spr.sprite == sprites[0] ? sprites[1] : sprites[0];
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            collision.gameObject.GetComponent<playerScript>().points += point;
            Destroy(this.transform.parent.gameObject);

        }
    }
}

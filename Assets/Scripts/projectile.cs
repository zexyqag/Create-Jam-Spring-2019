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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.layer == 8 || collision.gameObject.layer == 9 || collision.gameObject.layer == 12 || collision.gameObject.layer == 11) && collision.gameObject != player)
        {
            if (collision.gameObject.layer == 9)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, collision.gameObject.GetComponent<Rigidbody2D>().velocity.y);
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(direction * 250, 0));
            }

            Destroy(this.transform.parent.gameObject);
        }
    }
}

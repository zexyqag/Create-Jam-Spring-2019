using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public Rigidbody2D rbplayer;
    public float speed;
    public BoxCollider2D col;
    public float jumpF;
    private bool jumpR = false;
    public int points;
    public int direction;
    private bool shootR = false;
    public GameObject bullets;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        if(!Mathf.Approximately(Input.GetAxisRaw("Horizontal"), 0))
        {
            direction = (int)Input.GetAxisRaw("Horizontal");
        }

        rbplayer.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0));
        if(Mathf.Approximately(Input.GetAxisRaw("Jump"), 1)){
            if(jumpR == false){
                jumpR = true;
                rbplayer.AddForce(new Vector2(0, (col.IsTouchingLayers(LayerMask.GetMask("Floor")) ? 1 : 0) * jumpF * Input.GetAxisRaw("Jump")));
            }
        }
        if(Mathf.Approximately(Input.GetAxisRaw("Jump"), 0)){
            jumpR = false;
        }


        if (Mathf.Approximately(Input.GetAxisRaw("Shoot"), 1))
        {
            if (shootR == false)
            {
                shootR = true;
                GameObject bullet = Instantiate(bullets);
                bullet.transform.position = this.gameObject.transform.position;
                bullet.gameObject.GetComponent<projectile>().direction = direction;
            }
        }
        if (Mathf.Approximately(Input.GetAxisRaw("Shoot"), 0))
        {
            shootR  = false;
        }

    }
}

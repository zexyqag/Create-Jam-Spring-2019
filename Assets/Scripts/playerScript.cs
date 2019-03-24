using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public Rigidbody2D rbplayer;
    public int PID;
    public float speed;
    public Collider2D col;
    public float jumpF;
    private bool jumpR = false;
    public int points;
    public int direction;
    private bool shootR = false;
    public GameObject bullets;
    public AudioClip shooting, jumping;
 

    void FixedUpdate()
    {
        if(!Mathf.Approximately(Input.GetAxisRaw("Horizontal" + PID), 0))
        {
            direction = (int)Input.GetAxisRaw("Horizontal" + PID);
        }

        rbplayer.AddForce(new Vector2(Input.GetAxisRaw("Horizontal" + PID) * speed, 0));
        if(Mathf.Approximately(Input.GetAxisRaw("Jump" + PID), 1)){
            if(jumpR == false){
                jumpR = true;

                if (col.IsTouchingLayers(LayerMask.GetMask("Floor")))
                {
 
                    this.GetComponent<AudioSource>().clip = jumping;
                    this.GetComponent<AudioSource>().Play();
                }

                rbplayer.AddForce(new Vector2(0, (col.IsTouchingLayers(LayerMask.GetMask("Floor")) ? 1 : 0) * jumpF * Input.GetAxisRaw("Jump" + PID)));
            }
        }
        if(Mathf.Approximately(Input.GetAxisRaw("Jump" + PID), 0)){
            jumpR = false;
        }


        if (Mathf.Approximately(Input.GetAxisRaw("Shoot" + PID), 1))
        {
            if (shootR == false)
            {
                shootR = true;
                this.GetComponent<AudioSource>().clip = shooting;
                this.GetComponent<AudioSource>().Play();
                GameObject bullet = Instantiate(bullets);

                bullet.transform.position = this.gameObject.transform.position;
                bullet.GetComponentInChildren<projectile>().direction = direction;
                bullet.GetComponentInChildren<projectile>().player = this.gameObject;
            }
        }
        if (Mathf.Approximately(Input.GetAxisRaw("Shoot" + PID), 0))
        {
            shootR  = false;
        }

    }
}

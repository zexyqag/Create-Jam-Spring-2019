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

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        rbplayer.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * speed, 0));
        if(Mathf.Approximately(Input.GetAxisRaw("Vertical"), 1)){
            if(jumpR == false){
                jumpR = true;
                rbplayer.AddForce(new Vector2(0, (col.IsTouchingLayers(LayerMask.GetMask("Floor")) ? 1 : 0) * jumpF * Input.GetAxisRaw("Vertical")));
            }
        }
        if(Mathf.Approximately(Input.GetAxisRaw("Vertical"), 0)){
            jumpR = false;
        }
    }
}

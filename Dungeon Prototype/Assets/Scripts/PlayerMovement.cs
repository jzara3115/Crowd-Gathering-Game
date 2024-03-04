using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;

    public float speed;
    private float moveInputx;
    private float moveInputy;
    //GameObject pan;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
        speed = 5;
       // pan = GameObject.Find("Panel");
        
    }

    void Update()
    {
       moveInputx = Input.GetAxis("Horizontal");
       moveInputy = Input.GetAxis("Vertical");
       rb.velocity = new Vector2(moveInputx * speed, moveInputy * speed);
    //   Debug.Log(moveInputx);

    //    if (moveInputx > 0 ) {
    //        anim.walk_right.bool(true);
    //    }

    //  void OnCollisionEnter2D(Collision2D col) {
        
    //     if (col.gameObject.tag == "trigger"){
    //         Debug.Log("colliding");
    //     anim.SetBool("Black", true);
    //     }
            
     }

    }





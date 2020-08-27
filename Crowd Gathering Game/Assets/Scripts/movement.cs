using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    private float moveInput;
    private float moveInput2;



    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate() {

    }

    // Update is called once per frame
    void Update()
    {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector3(moveInput * speed, rb.velocity.y, rb.velocity.z);
            
            moveInput2 = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveInput2 * speed);
        
    }

    void OnTriggerEnter(Collider cldr)
    {
        Destroy(cldr.gameObject);
    }
}

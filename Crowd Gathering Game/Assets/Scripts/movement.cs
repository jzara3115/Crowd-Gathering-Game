using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody rb;
    // public CharacterController charController;
    public float speed;
    private float moveInput;
    private float moveInput2;
    public Transform cam;

    public float turnSmoothTime = 0.1f;
    public float turnSmoothVelocity;



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
            moveInput2 = Input.GetAxis("Vertical");
            //rb.velocity = new Vector3(moveInput * speed, rb.velocity.y,  moveInput2 * speed);
            Vector3 direction = new Vector3(moveInput, 0f, moveInput2).normalized;
        

            if (direction.magnitude >= 0.1f) {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation= Quaternion.Euler(0f,angle,0f);

                Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                rb.velocity = (moveDir * speed);
            }
    }
}

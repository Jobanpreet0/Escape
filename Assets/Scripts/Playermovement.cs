using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
 
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -5.77f, -0.72f),
            Mathf.Clamp(transform.position.y, -3.19f, 3.19f));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


}

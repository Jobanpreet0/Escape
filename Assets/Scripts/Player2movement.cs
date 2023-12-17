using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private Vector2 forBoarders;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -5.77f, -0.72f),
            Mathf.Clamp(transform.position.y, -3.19f, 3.19f));
    }

}
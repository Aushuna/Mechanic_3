using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed, SpeedA;
    private float Move;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        
        if (Input.GetKeyDown(KeyCode.N))
        {
            Speed =  Speed / 2;
            rb.velocity = new Vector2((Move * Speed), rb.velocity.y);
            Debug.Log("pressed");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            Speed = Speed * 2;
            rb.velocity = new Vector2((Move * Speed), rb.velocity.y);
            Debug.Log("pressed");
        }
        else
        {
            rb.velocity = new Vector2(Move * Speed, rb.velocity.y);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    public float speed = 5f, xbound;
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        
        if (h > 0)
        {
            myBody.velocity = Vector2.right * speed;
        }
        else if (h < 0)
        {
            myBody.velocity = Vector2.left * speed;
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }


        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xbound, xbound), transform.position.y);
    }
}

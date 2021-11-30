using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    private bool started;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.velocity = new Vector3(0,0,speed);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            SwitchDirection();
        }
    }

    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed,0,0);
        }
        else if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0,0,speed);
        }
    }
}

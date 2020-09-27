using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int vitesseLaterale = 500;
    public float forceSaut = 1;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        transform.position += Vector3.right * vitesseLaterale * Time.deltaTime;
        if(Input.GetKey("space"))
        {
            rb.velocity = Vector2.up * forceSaut;
        }
    }
}
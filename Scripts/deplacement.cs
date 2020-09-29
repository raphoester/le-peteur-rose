using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr ;
    private AudioSource AS;
    public int vitesseLaterale = 500;
    public float forceSaut = 1;
    public Sprite basique;
    public Sprite animationSaut;
    private int resultat = 0;
    public List<AudioClip> prouts = new List<AudioClip>();
    System.Random rnd = new System.Random();
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        AS = GetComponent<AudioSource>();
    }
    
    void FixedUpdate()
    {
        transform.position += Vector3.right * vitesseLaterale * Time.deltaTime;
        if(Input.GetKey("space"))
        {
            resultat = rnd.Next(1, prouts.Count);
            AS.clip = prouts[resultat];
            AS.Play();
            rb.velocity = Vector2.up * forceSaut;
            sr.sprite = animationSaut;
        }

        if (rb.velocity.y <= 0)
        {
            sr.sprite = basique;
        }
    }
}
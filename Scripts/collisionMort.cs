using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionMort : MonoBehaviour
{
    public GameObject prout;
    public float positionMortY = -4.6f;
    public Sprite animationMort;
    private SpriteRenderer sprite ;
    private AudioSource AS;
    public AudioClip sonMort;
    private void Start()
    {
        AS = prout.GetComponent<AudioSource>();
        sprite = prout.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Vector3 nouvellePosition = new Vector3(prout.transform.position.x, positionMortY, 0);
        transform.position = nouvellePosition;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "prout")
        {
            AS.clip = sonMort;
            AS.Play();
            prout.GetComponent<deplacement>().enabled = false;
            sprite.sprite = animationMort;

        }
    }
}

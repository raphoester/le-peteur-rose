using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionMort : MonoBehaviour
{
    public GameObject prout;
    public float positionMortY = -5.11f;

    private void Update()
    {
        Vector3 nouvellePosition = new Vector3(prout.transform.position.x, positionMortY, 0);
        transform.position = nouvellePosition;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("Collision détectée");
        if (collision.gameObject.name == "prout"){
            Debug.Log("Défaite !");
            prout.GetComponent<deplacement>().enabled = false;
        }
    }
}

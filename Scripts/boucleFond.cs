using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boucleFond : MonoBehaviour
{
    public GameObject imageFond1 ;
    public GameObject imageFond2 ;
    public float largeurImage = 30f;
    public Transform joueur ;
    public Vector3 positionImage = new Vector3();
    private int fondABouger = -1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        positionImage.x = largeurImage;
    }

    // Update is called once per frame
    void Update()
    {
        if (joueur.position.x >= positionImage.x)
        {
            positionImage.x += 30;
            if (fondABouger == -1)
            {
                imageFond1.transform.position = positionImage;
            }
            else 
            {
                imageFond2.transform.position = positionImage;
            }
            fondABouger *= -1; 
        }
    }
}

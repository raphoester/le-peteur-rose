using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementCamera : MonoBehaviour
{
    public Transform prout;
    void LateUpdate()
    {
        Vector3 nouvellePosition = new Vector3(prout.position.x, 0, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, nouvellePosition, 1);
    }
}

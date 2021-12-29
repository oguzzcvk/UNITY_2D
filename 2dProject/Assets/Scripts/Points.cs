using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
}

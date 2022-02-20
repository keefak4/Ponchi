using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isPlayer;
   
    private void OnTriggerEnter(Collider other)
    {
        BasicUnity basicUnity = other.GetComponent<BasicUnity>();
        if(basicUnity && isPlayer )
        {
            Destroy(gameObject);
        }
    }
}

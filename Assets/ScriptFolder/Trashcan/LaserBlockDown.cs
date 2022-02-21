using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBlockDown : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        BasicUnity basicUnity = other.GetComponent<BasicUnity>();
        if(basicUnity && basicUnity is Controler)
        {
            basicUnity.ReciewDamage();
        }
    }
}

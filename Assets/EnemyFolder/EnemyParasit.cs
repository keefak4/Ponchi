using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParasit : BasicUnity
{
    private void OnTriggerEnter(Collider other)
    {
        Bullet bullet = other.GetComponent<Bullet>();
        if(bullet)
        {
            ReciewDamage();
        }
    }
}

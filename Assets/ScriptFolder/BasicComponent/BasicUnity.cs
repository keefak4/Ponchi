using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUnity : MonoBehaviour
{
    public virtual void ReciewDamage()
    {
        Die();
    }
    protected void Die()
    {
        Destroy(gameObject);
    }
}

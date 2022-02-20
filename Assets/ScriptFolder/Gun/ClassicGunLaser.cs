using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicGunLaser : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject transformGunPosition;
    [SerializeField] private float powerShot;
    

  
    private void LogicShot()
    {
         GameObject bullet = Instantiate(bulletPrefab, transformGunPosition.transform.position, Quaternion.identity);
         bullet.GetComponent<Rigidbody>().AddForce(transform.up * powerShot);
         Destroy(bullet, 2f);
    }
    
}

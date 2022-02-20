using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicPullMen : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject transformBulletPosition;
    [SerializeField] private float powerShot;

    public void LogicGun()
    {       
            GameObject bullet = Instantiate(bulletPrefab, transformBulletPosition.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.up * powerShot);
            Destroy(bullet, 2f);   
    }
    
}

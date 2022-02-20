using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopColiderToSide : MonoBehaviour
{
    //Изменяемые компоненты в Инспекторе
    [SerializeField] private GameObject teleportBlockPost;
    [SerializeField] private float powerShot;
    [SerializeField] private GameObject closeTeleportBlockPost;
    //Используемые в коде компоненты
    private Controler controler;
    private void Start()
    {
        controler = FindObjectOfType<Controler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") )
        {
            other.gameObject.transform.position = teleportBlockPost.transform.position;
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.right * powerShot);
            StartCoroutine(CorBlock());
        }
        
    }
    private IEnumerator CorBlock()
    {
        closeTeleportBlockPost.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        closeTeleportBlockPost.SetActive(true);
    }
}

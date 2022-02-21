using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : BasicUnity
{
    //Ссылки на компоненты из Инспектора
    private Rigidbody rigidbody3d;
    //Изменяемые компоненты в Инспекторе
    [SerializeField] private float speedNormal;
    [SerializeField] private int health;
    [SerializeField] private Joystick joystick;
    [SerializeField] private GameObject protectiveCircle;
    [SerializeField] private GameObject positionPlayerDead;
    [SerializeField] private GameObject effectOfImortalTransformPosition;
    //Используемые переменные внутри кода
    private Vector3 moveComponent;
    private bool isEffectImortal;
    
    private void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        LogicMove();
    }
    
    private void LogicMove()
    {
        float movementX = joystick.Horizontal;
        float movementY = joystick.Vertical;
        Vector3 movement = new Vector3(movementX, movementY, 0);
        rigidbody3d.AddForce(movement * speedNormal);
    }
    public override void ReciewDamage()
    {
        StartCoroutine(Dead());
    }
    private IEnumerator Dead()
    {
        health--;
        yield return new WaitForSeconds(0.1f);
        protectiveCircle.SetActive(true);
        isEffectImortal = true;
        transform.position = positionPlayerDead.transform.position;
        yield return new WaitForSeconds(0.2f);
        transform.position = new Vector3(transform.position.x, transform.position.y, effectOfImortalTransformPosition.transform.position.z);
        yield return new WaitForSeconds(2f);
        protectiveCircle.SetActive(false);
        isEffectImortal = false;
        transform.position = new Vector3(transform.position.x,transform.position.y,0);
    }
    

}

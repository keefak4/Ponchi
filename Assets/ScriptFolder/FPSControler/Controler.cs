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
    //Используемые переменные внутри кода
    private Vector3 moveComponent;
    
    private void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        LogicMove();
    }
    private void FixedUpdate()
    {
        
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
        health--;
        Debug.Log(health);
    }

}

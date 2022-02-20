using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y + speed * Time.deltaTime,transform.position.z);
    }
}

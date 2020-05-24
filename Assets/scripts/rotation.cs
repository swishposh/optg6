using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // переменная, отвечающая за скорость вращения вокруг своей оси     
    public float rotationSpeed;     
    // скорость движения по орбите     
    public float movementSpeed;     
    // центр объекта, вокруг которого происходит вращение     
    public GameObject center;

    void Update ()      
    {         
        // вращение вокруг своей оси         
        transform.Rotate ((Vector3.up * rotationSpeed) * Time.deltaTime, Space.Self);
        // вращение вокруг объекта (солнца или планеты)         
        transform.RotateAround(center.transform.position, Vector3.up, movementSpeed * Time.deltaTime);
    } 
}

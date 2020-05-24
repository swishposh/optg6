using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    //public int speed = 10;//Наша скорость
    //public GameObject cameraa;

    public float keyMoveSpeed = 5.0f;

    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    cameraa.transform.position += cameraa.transform.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    cameraa.transform.position -= cameraa.transform.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    cameraa.transform.position -= cameraa.transform.right * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    cameraa.transform.position += cameraa.transform.right * speed * Time.deltaTime;
        //}

        // Движение камеры с клавиатуры
        if ((Input.GetAxisRaw("Horizontal") != 0) || (Input.GetAxisRaw("Vertical") != 0))
        {
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0,
                                               Input.GetAxisRaw("Vertical")) * Time.deltaTime * keyMoveSpeed;
        }
    }
}
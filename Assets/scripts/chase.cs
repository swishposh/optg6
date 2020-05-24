using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class chase : MonoBehaviour
{
    //переменная, определяющая, включен ли режим слежения     
    bool chaseB = false;     
    //ссылки на камеру и планету, за которой нужно следить     
    GameObject planet;    
    GameObject cam;

    GameObject merc;
    GameObject venus;
    GameObject earth;
    GameObject mars;

    GameObject banner;

    Vector3 position;
    float a = 0.0f;

    //public GameObject[] bPlanets;

    public GameObject[] images;

    void Start()
    {
        merc = GameObject.Find("imMercury");
        venus = GameObject.Find("imVenus");
        earth = GameObject.Find("imEarth");
        mars = GameObject.Find("imMars");
        merc.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
    }

    void Update()
    {
       // imMars.SetActive(false);
    }

    //функция установки планеты для слежения    
    public void Chase_Planet(GameObject p)    
    {         
    //режим слежения - включить         
        chaseB = true;         
        //назначить планету для слежения        
        planet = p;         
        //найти ссылку на камеру         
        cam = GameObject.Find ("Camera");     

    }
    public void img(GameObject im)
    {
        merc.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
        banner = im;
    }

    //функция установки камеры в начальную позицию     
    public void Camera_Reset(GameObject sun)     
    {         
        //режим слежения - отключить         
        chaseB = false;         
        //найти  ссылку на камеру         
        cam = GameObject.Find ("Camera");         
        //установить начальную позицию камеры         
        cam.transform.position = new Vector3 (0, 180, 0);         
        //повернуть камеру в сторону солнца         
        cam.transform.LookAt (sun.transform);

        merc.SetActive(false);
        venus.SetActive(false);
        earth.SetActive(false);
        mars.SetActive(false);
    }

    void LateUpdate()     
    {         
        //если включён режим слежения         
        if (chaseB == true) 
        {             
            //установить камеру в позицию на орбите планеты             
            cam.transform.position = planet.transform.position +                                                                
                new Vector3 (15, 10, 0);             
            //повернуть камеру в направлении центра планеты             
            cam.transform.LookAt (planet.transform);
            banner.SetActive(true);
        }

        if (planet != null)
        {
            Vector3 center = planet.transform.position;

            if (Input.GetKey(KeyCode.D))
            {
                a += 0.01f;

                position.x = (float)(center.x + 25.0f * Math.Cos(a));
                position.y = 10.0f;
                position.z = (float)(center.z + 25.0f * Math.Sin(a));

                cam.transform.position = (position);
                cam.transform.LookAt(center);
            }

            if (Input.GetKey(KeyCode.A))
            {
                a -= 0.01f;

                position.x = (float)(center.x + 25.0f * Math.Cos(a));
                position.y = 10.0f;
                position.z = (float)(center.z + 25.0f * Math.Sin(a));

                cam.transform.position = (position);
                cam.transform.LookAt(center);
            }

            if (Input.GetKey(KeyCode.W))
            {
                a += 0.01f;

                position.x = 10.0f;
                position.y = (float)(center.x + 2.0f * Math.Cos(a));
                position.z = (float)(center.x + 2.0f * Math.Cos(a));

                cam.transform.position = (position);
                cam.transform.LookAt(center);
            }

            if (Input.GetKey(KeyCode.S))
            {
                a -= 0.01f;

                position.x = 10.0f;
                position.y = (float)(center.x + 2.0f * Math.Cos(a));
                position.z = (float)(center.x + 2.0f * Math.Cos(a));

                cam.transform.position = (position);
                cam.transform.LookAt(center);
            }
        }
    }
}

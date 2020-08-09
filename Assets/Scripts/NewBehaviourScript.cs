using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System;
using System.Security.Cryptography;
using System.Net.Sockets;

public class NewBehaviourScript : MonoBehaviour
{
    

    void Start()
    {
        
    }


    void Update()
    {


        if (transform.position[0] < 0)
        {
            transform.position = transform.position + new Vector3(Time.deltaTime * 0.5f, Time.deltaTime * -2.5f, Time.deltaTime * 2f);
        }

        else
        {
            transform.position = transform.position + new Vector3(0, Time.deltaTime * 3f, Time.deltaTime * -3.5f);
        }
        

    }
}
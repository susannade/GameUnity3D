using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform teleporter_target;
    public GameObject LOVEDUCK;

    void OnTriggerEnter(Collider other)
    {
        LOVEDUCK.transform.position = teleporter_target.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tu");
        if (other.CompareTag("Wall") || other.CompareTag("Coin"))
        {
            Debug.Log("Tutaj wall");
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }
    

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int score = 0;
    int health = 3;
    int stars = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Enemy"))
        {
            health--;
            Debug.Log("Health: " + health);
            
        }
        if (other.CompareTag("Cat") && stars==3)
        {
            Debug.Log("FAJERWERKI");
        }
        if (other.CompareTag("Cat") && stars != 3)
        {
            Debug.Log("ZNAJDZ GWIAZDY");
        }
        if (other.CompareTag("Star") && stars != 3)
        {
            stars++;
            other.gameObject.SetActive(false);
            Debug.Log("Stars:"+stars);
        }
    }
    void Start()
    {
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

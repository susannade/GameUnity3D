using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float Speed;
    public Rigidbody rb;
    public bool isGrounded;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    

    void PlayerMovement() // odpowiada za ruch i skoki gracza
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }

    }
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Ground") // je¿eli dodajecie coœ i chcecie zeby dalej skaka³o z tej powiechni to dodajcie tag 'Ground'
        {
            isGrounded = true;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
//robione przez zuze
public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform Target, LOVEDUCK;
    float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        LOVEDUCK.rotation = Quaternion.Euler(0, mouseX, 0);
    }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public float xRotation = 0f;
    public float yRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;
    
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //Izra�una se camera rotation za gledanje gor in dol
        xRotation -= (mouseY * Time.deltaTime)*ySensitivity; //gor dol
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        cam.transform.localRotation = Quaternion.Euler(xRotation,0, 0 );

        transform.Rotate(Vector3.up*(mouseX*Time.deltaTime)*xSensitivity); //levo desno
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwingLook : MonoBehaviour
{
    public Camera cam;

    public float xRotation = 0f;
    public float yRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    private Vector3 rotateDir = Vector3.zero;
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        //Izraèuna se camera rotation za gledanje gor in dol
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        yRotation -= (mouseX * Time.deltaTime) * ySensitivity;
        yRotation = Mathf.Clamp(yRotation, -160, 160);

        cam.transform.rotation = Quaternion.Euler(xRotation, -yRotation, 0);


    }
}

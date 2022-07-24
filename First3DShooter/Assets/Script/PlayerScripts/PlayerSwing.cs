using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject rope;
    [SerializeField]
    private float swingSpeed=5f;
    [SerializeField]
    private Camera cam;


    private CharacterController controller;


    public void Start()
    {
        controller = GetComponent<CharacterController>();
  
    }

    public void ProcessSwing(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        Vector3 direction = Vector3.zero;
        direction.x = input.x;
        direction.z = input.y;
    
        gameObject.GetComponent<Rigidbody>().AddForce(direction * swingSpeed, ForceMode.Acceleration);
        
        rope.GetComponent<Rigidbody>().AddForce(direction* swingSpeed, ForceMode.Acceleration);

        
    }
}

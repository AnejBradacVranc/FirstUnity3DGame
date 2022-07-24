using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;

    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public float speed = 5f;
    public float weight=-2f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
    }

    //Sprejema inputs iz inputManager in jih da v character controller.
    public void ProcessMove(Vector2 input)
    {
        Vector3 direction = Vector3.zero;
        direction.x = input.x;
        direction.z = input.y;

        controller.Move(transform.TransformDirection(direction)*speed*Time.deltaTime);
        
        playerVelocity.y += gravity*Time.deltaTime;

        if (isGrounded && playerVelocity.y < 0)
            playerVelocity.y = weight;

        controller.Move(playerVelocity * Time.deltaTime);

        Debug.Log(playerVelocity.y);

    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

    }
   
}

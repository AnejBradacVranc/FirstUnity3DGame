using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFootActions;
    public PlayerInput.SwingingActions onSwingActions;

    private PlayerMovement movement;
    private PlayerSwingLook playerSwingLook;
    private PlayerLook playerLook;
    private PlayerSwing playerSwing;

    //enum switch
    void Awake()
    {
        playerInput = new PlayerInput();
        onFootActions = playerInput.OnFoot;
        onSwingActions = playerInput.Swinging;
        
        movement = GetComponent<PlayerMovement>();
        playerLook = GetComponent<PlayerLook>();
        playerSwingLook=GetComponent<PlayerSwingLook>();
        playerSwing = GetComponent<PlayerSwing>();

        onFootActions.Jump.performed += ctx => movement.Jump(); //Pointer ctx (callback context) se pošlje v Jump .preformed, .started, .cancelled
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // pogoj ce swinga
        if (Rope.isSwinging)
        {
            Debug.Log("Is Swinging RN");
            playerSwing.ProcessSwing(onSwingActions.Movement.ReadValue<Vector2>());
            //onFootActions.Disable();
        }
        else
        {
         
            movement.ProcessMove(onFootActions.Movement.ReadValue<Vector2>());
        }

    }


    private void Update()
    {
       
    }

    private void LateUpdate() //Zadnji po vseh updatih
    {
        if (Rope.isSwinging)
        {
            playerSwingLook.ProcessLook(onSwingActions.Look.ReadValue<Vector2>());
        }
        else
        {
            playerLook.ProcessLook(onFootActions.Look.ReadValue<Vector2>());
        }
       
    }

    private void OnEnable()
    {
        onFootActions.Enable();
        onSwingActions.Enable();

    }

    private void OnDisable()
    {
        onFootActions.Disable();
        onSwingActions.Disable();
    }
}

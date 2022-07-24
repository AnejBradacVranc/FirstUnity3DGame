using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : Interactable
{

    public static bool isSwinging=false;
    [SerializeField]
    private GameObject player;
    private Rigidbody playerRb;
    private ConfigurableJoint playerJoint;
    private CapsuleCollider capsuleCollider;

    void Start()
    {
        playerJoint = player.GetComponent<ConfigurableJoint>();
        playerRb = player.GetComponent<Rigidbody>();
        capsuleCollider=player.GetComponent<CapsuleCollider>();        
        isSwinging = false;        
    }

    void FixedUpdate()
    {
    }

    protected override void Interact()
    {

        isSwinging = !isSwinging;
        playerRb.isKinematic = !playerRb.isKinematic;
        capsuleCollider.enabled = !capsuleCollider.enabled;

        if (isSwinging)         
            playerJoint.connectedBody = gameObject.GetComponent<Rigidbody>();
        
        else
            playerJoint.connectedBody = null;


    }
}

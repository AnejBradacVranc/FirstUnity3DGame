using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        doorOpen = !doorOpen;  //toggla med true in false 
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}

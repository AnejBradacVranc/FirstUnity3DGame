using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public abstract class Interactable : MonoBehaviour  //za dostop do tega razreda mora na objektu biti podedovan
{
    //Tukaj bodo podrazredi. Ce bomo hoteli da igralec interacta z predmetom bo moral imeti program ki inherita od tu

    public bool useEvents;
    [SerializeField]
    public string promptMessage;
    //Template method pattern

    public void BaseIneract()
    {  //Events bodo se za�eli prvo interactions pa kasneje
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke(); //Ustvari eventOnInteract in kli�e Interact

        Interact();
    }
    protected virtual void Interact()
    {
        //To je template funkcije ki bo overriden od podrazredov
    }
}

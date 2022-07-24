using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHands : MonoBehaviour
{
    [SerializeField]
    private GameObject lHand;
    [SerializeField]
    private GameObject rHand;
    [SerializeField]
    private Camera cam;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = gameObject.transform.position;
        rHand.transform.position = gameObject.transform.position;
        rHand.transform.rotation = gameObject.transform.rotation;
    }
}

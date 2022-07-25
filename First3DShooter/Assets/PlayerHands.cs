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
    private PlayerLook playerLook;
    Vector3 camPos;


    // Start is called before the first frame update
    void Start()
    {
      playerLook=gameObject.GetComponent<PlayerLook>(); 
      camPos=cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        Vector3 camPosTemp = new Vector3(camPos.x, camPos.y, camPos.z);
        pos = camPosTemp + cam.transform.forward;
        Quaternion rot = cam.transform.rotation;
        //rHand.transform.localRotation = Quaternion.Euler(playerLook.xRotation, 0, 0);
        //rHand.transform.Rotate(Vector3.up * (playerLook.xMouse * Time.deltaTime) * playerLook.xSensitivity);
        rHand.transform.position=pos;
        rHand.transform.rotation=rot;
    }
}

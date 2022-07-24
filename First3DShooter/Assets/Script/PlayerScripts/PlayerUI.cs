using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //TEXT MESH PRO

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateText(string message)
    {
        promptText.text = message;
    }
}

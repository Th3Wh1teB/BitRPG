using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text coinText;

    public float coins = 10;

    private void Awake(){
        instance = this;
    }
    private void Update(){
        coinText.text = $"x{coins}";

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Door door = GameObject.Find("Door").GetComponent<Door>();
            door.Open();


        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Door door = GameObject.Find("Door").GetComponent<Door>();
            door.Close();


        }
    }
    
}

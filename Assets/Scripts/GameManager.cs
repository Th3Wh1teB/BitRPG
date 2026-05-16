using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    }
    
}

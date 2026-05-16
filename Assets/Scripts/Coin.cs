using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"));
        Collect();
    }
    public void Collect()
    {
        //Dodanie wartosci

        Destroy(gameObject);
    }
}

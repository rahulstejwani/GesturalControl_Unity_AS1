using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunaBehavior : MonoBehaviour
{
    public static int score = 0;
    AudioSource source;

    void Awake()
    { 
        source = GetComponent<AudioSource>();
    }
    void Update(){}

    // dictates actions that will happen when paw touches tuna
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Paw"))
        {
            //Debug.Log("IS PAW!");
            Destroy(this.gameObject); // Destroy the caught tuna
            ScoreCounter.instance.IncreaseScore(); // Increment score
        }
    }
}
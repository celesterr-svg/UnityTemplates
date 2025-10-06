using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [Header("Spikes to destroy")]
    public GameObject[] spikes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(spikes.Length > 0)
            {
                foreach (GameObject spike in spikes) 
                {
                    spike.SetActive(false);
                }
            }            
        }
    }
}

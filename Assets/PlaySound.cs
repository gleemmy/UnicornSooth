using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public static PlaySound Instance; // Change to static
    public AudioSource wanishSound;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destroy the GameObject, not the script
        }
        else
        {
            Instance = this;
        }
    }

}

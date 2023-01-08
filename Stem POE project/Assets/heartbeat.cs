using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
{
    public AudioSource audioSource;
    //public AudioClip ambience;

    public bool sound = false;

    private PlayerInteract playerInteract;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInteract.mushroomCount == 1 && sound == false)
        {
            audioSource.Play();
            sound = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
   
    Vector3 spawnPoint = new Vector3(38.73f, 5.08f, 3.52f);
    Animator animator;
    PlayerInteract playerInteract;
    public AudioSource audioSource;
    public AudioClip lever;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.flipped == true)
        {
            animator.SetBool("SwitchFlipped", true);

            audioSource.PlayOneShot(lever);

            


        }
    }
}

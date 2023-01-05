using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    Animator animator;
    PlayerInteract playerInteract;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.flipped == true)
        {
            animator.SetBool("SwitchFlipped", true);
        }
    }
}

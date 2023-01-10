using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom1 : Interactable
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickupSound;
    private PlayerInteract playerInteract;
    private bool done = false;
    public bool interacted1 = false;
    // Start is called before the first frame update
    void Start()
    {
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();

        audioSource = GetComponent<AudioSource>();
        if(audioSource == null)
        {
            Debug.LogError("AudioSource is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interacted1 == true)
        {

            audioSource.PlayOneShot(pickupSound);
            transform.position = new Vector3(0, -105, 0);
            interacted1 = false;
        }
        if (interacted1 == false && playerInteract.mushroomCount == 1 && !done)
        {
            transform.localScale += new Vector3(1, 1, 1);
            GetComponent<Light>().intensity = 3;
            done = true;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom4 : Interactable
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickupSound;

    public bool interacted4 = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource == null)
        {
            Debug.LogError("AudioSource is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interacted4 == true)
        {

            audioSource.PlayOneShot(pickupSound);
            transform.position = new Vector3(0, -105, 0);
            interacted4 = false;
        }
    }


}

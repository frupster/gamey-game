using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : Interactable
{
    private AudioSource audioSource;
    public bool interacted = false;
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
        if (interacted == true)
        {
            
            
            transform.position = new Vector3(0, -100, 0);

        }
    }

    //this function is where we will design our interaction using code
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}

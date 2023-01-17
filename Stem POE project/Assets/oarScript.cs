using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oarScript : MonoBehaviour
{
    private PlayerInteract playerInteract;
    [SerializeField] private AudioSource audioSource;

    private bool done;
    // Start is called before the first frame update
    void Start()
    {
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.oarCollected == true && done == false)
        {
            transform.position = new Vector3(0, -1000, 0);
            audioSource.Play();
            done = true;
        }
    }
}

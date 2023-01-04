using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveMushroomsRemaining : MonoBehaviour
{
    private PlayerInteract playerInteract;


    // Start is called before the first frame update
    void Start()
    {
        playerInteract = GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.mushroomCount != 5)
        {
            transform.Translate(100, 100, 100);
        }
    }
}
 
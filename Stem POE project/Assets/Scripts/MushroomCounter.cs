using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCounter : MonoBehaviour
{
    private PlayerUI playerUI;
    private PlayerInteract playerInteract;

    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        playerInteract = GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (playerInteract.mushroomCount == 5)
       // {
       //     Debug.Log("5 mushrooms");
//playerUI.UpdateCount("5 mushrooms remaining");
      //  }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No3 : MonoBehaviour
{
    private PlayerInteract playerInteract;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerInteract = player.GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.mushroomCount == 3)
        {

            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(161, -151);
        }

        if (playerInteract.mushroomCount != 3)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(1000, 1000);
        }


    }
}
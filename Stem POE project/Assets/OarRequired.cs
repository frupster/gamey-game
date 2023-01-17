using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OarRequired : MonoBehaviour
{
    private PlayerInteract playerInteract;
    // Start is called before the first frame update
    void Start()
    {
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInteract.boatInteractable == true && playerInteract.oarCollected == false)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(-191, -320);
        }
        else if (playerInteract.boatInteractable == false)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(1000, 1000);
        }
    }
}

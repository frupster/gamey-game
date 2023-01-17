using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectOar : MonoBehaviour
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
        if (playerInteract.oarInteractable == true && playerInteract.oarCollected == false)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(-93, -273);
        }
        else if (playerInteract.oarInteractable == false || playerInteract.oarCollected == true)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(1000, 1000);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashing : MonoBehaviour
{
    private PlayerInteract playerInteract;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInteract.mushroomCount == 1 && done == false)
        {
            StartCoroutine(Flash());
        }
    }

    IEnumerator Flash()
    {
        RectTransform picture = GetComponent<RectTransform>();
        picture.anchoredPosition = new Vector2(-36, 0);
        yield return new WaitForSeconds(0.5f);
        picture.anchoredPosition = new Vector2(1200, 0);
        yield return new WaitForSeconds(0.1f);
        picture.anchoredPosition = new Vector2(-36, 0);
        yield return new WaitForSeconds(0.5f);
        picture.anchoredPosition = new Vector2(1200, 0);
        yield return new WaitForSeconds(0.6f);
        picture.anchoredPosition = new Vector2(-36, 0);
        yield return new WaitForSeconds(0.5f);
        picture.anchoredPosition = new Vector2(1200, 0);
        yield return new WaitForSeconds(0.2f);
        picture.anchoredPosition = new Vector2(-36, 0);
        yield return new WaitForSeconds(0.9f);
        picture.anchoredPosition = new Vector2(1200, 0);
        yield return new WaitForSeconds(0.5f);
        done = true;
    }
}

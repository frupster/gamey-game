using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    private EnemyAI enemyAI;
    public PlayerInteract playerInteract;

    public bool chasing;
    // Start is called before the first frame update
    void Start()
    {
        enemyAI = GameObject.Find("Enemy").GetComponent<EnemyAI>();
        playerInteract = GameObject.Find("Player").GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chasing == true)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(-149, -128);
        }
        else if (chasing == false)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(1000, 1000);
        }
      
        
        }
    }


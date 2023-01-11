using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull : MonoBehaviour
{
    private EnemyAI enemyAI;
    // Start is called before the first frame update
    void Start()
    {
        enemyAI = GameObject.Find("Enemy").GetComponent<EnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyAI.chasing == true)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(-149, -128);
        }
        else if (enemyAI.chasing == false)
        {
            RectTransform picture = GetComponent<RectTransform>();
            picture.anchoredPosition = new Vector2(1000, 1000);
        }
    }
}

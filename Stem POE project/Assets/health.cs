using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    private EnemyAI enemy;
    private DeathBox deathBox;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy").GetComponent<EnemyAI>();
        deathBox = GameObject.Find("Player").GetComponent<DeathBox>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.hit == true)
        {
            SceneManager.LoadScene("Death");

        }
        if(deathBox.drowned == true)
        {
            SceneManager.LoadScene("WaterDeath");
        }

    }
}

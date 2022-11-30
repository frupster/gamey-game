using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathBox : MonoBehaviour
{
    public GameObject player;
    public Vector3 SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.tag == "Player")
        {
            player.transform.position = SpawnPoint;
            
            
        }
    }
}

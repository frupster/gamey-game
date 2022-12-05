using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathBox : MonoBehaviour
{
    public GameObject deathBox;
    public Vector3 SpawnPoint;
    public bool respawn = false;
    SC_FPSController cc;
    //public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<SC_FPSController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(respawn == true)
        {
            cc.enabled = true;
           respawn = false;
        }
    }
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("DeathBox"))
        {
            Debug.Log("touched deathbox");
            //GetComponent<SC_FPSController>().enabled = false;
            
            cc.enabled = false;
            respawn = true;
            transform.position = SpawnPoint;
           

        }
    }
}

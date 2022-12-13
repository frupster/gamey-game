using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GrabbyHands : MonoBehaviour
{
    public GameObject player;
    private PlayerInteract bool_script;
    // Start is called before the first frame update
    void Start()
    {
        bool_script = player.GetComponent<PlayerInteract>();
    }

    // Update is called once per frame
    void Update()
    {
       if( bool_script.ableToBeInteracted == true)
        {
            //Debug.Log("interactable");
            //transform.position = new Vector3(0, 8, 0);
        }
       else
        {
            //Debug.Log("not interactable");
           // transform.position = new Vector3(0, 100, 0);
        }
    }
}

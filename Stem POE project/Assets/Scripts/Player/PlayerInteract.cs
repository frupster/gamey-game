using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Mushroom mushroom;
    private Camera cam;

    //[SerializeField]
    //private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;

    public float range = 5f;
    public bool ableToBeInteracted = false;
    // Start is called before the first frame update
    void Start()
    {

        mushroom = GameObject.Find("Mushroom").GetComponent<Mushroom>();
        cam = GetComponent<SC_FPSController>().playerCamera;
        playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //create ray at the center of the camera, shooting outwards
        /* Ray ray = new Ray(cam.transform.position, cam.transform.forward);
         Debug.DrawRay(ray.origin, ray.direction * distance);
         RaycastHit hitInfo; //variable to store collision information



             if (Physics.Raycast(ray, out hitInfo,distance,mask))
         {

             if (hitInfo.collider != null && hitInfo.transform.tag == "Mushroom")
             {
                 ableToBeInteracted = true;
                 playerUI.UpdateText(hitInfo.collider.GetComponent<Interactable>().promptMessage);
                 Debug.Log("interactable");


                 if (Input.GetKeyDown(KeyCode.E))
                 {
                     Debug.Log("collected");
                     mushroom.interacted = true;

                 }
             }
             if (hitInfo.collider == null && hitInfo.transform.tag == null )
             {
                 ableToBeInteracted = false;
                 Debug.Log("not interactable");


             }

         }*/

        Vector3 direction = Vector3.forward;
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * range);

        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Mushroom")
            {
                ableToBeInteracted = true;
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom.interacted = true;

                }
            }
            if (hit.collider.tag != "Mushroom")
            {
                ableToBeInteracted = false;
                Debug.Log("not interactable");
            }



        }
    }
}

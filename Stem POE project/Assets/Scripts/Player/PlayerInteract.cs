using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    
    private Mushroom mushroom;
    private Mushroom1 mushroom1;
    private Mushroom2 mushroom2;
    private Mushroom3 mushroom3;
    private Mushroom4 mushroom4;
    private Camera cam;

    //[SerializeField]
    //private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    
    public float range = 5f;
    public bool ableToBeInteracted = false;
    public int mushroomCount = 5;
    // Start is called before the first frame update
    void Start()
    {
        mushroom4 = GameObject.Find("Mushroom4").GetComponent<Mushroom4>();
        mushroom3 = GameObject.Find("Mushroom3").GetComponent<Mushroom3>();
        mushroom2 = GameObject.Find("Mushroom2").GetComponent<Mushroom2>();
        mushroom1 = GameObject.Find("Mushroom1").GetComponent<Mushroom1>();
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
                //Debug.Log("interactable");
                

                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom.interacted = true;
                    mushroomCount--;
                }
            }
            if (hit.collider.tag == "Mushroom1")
            {
                ableToBeInteracted = true;
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                //Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom1.interacted1 = true;
                    mushroomCount--;
                }
            }
            if (hit.collider.tag == "Mushroom2")
            {
                ableToBeInteracted = true;
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                //Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom2.interacted2 = true;
                    mushroomCount--;
                }
            }
            if (hit.collider.tag == "Mushroom3")
            {
                ableToBeInteracted = true;
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                //Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom3.interacted3 = true;
                    mushroomCount--;
                }
            }
            if (hit.collider.tag == "Mushroom4")
            {
                ableToBeInteracted = true;
                playerUI.UpdateText(hit.collider.GetComponent<Interactable>().promptMessage);
                //Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("collected");
                    mushroom4.interacted4 = true;
                    mushroomCount--;
                }
            }

            if (hit.collider.tag != "Mushroom" )
            {
                ableToBeInteracted = false;
                //Debug.Log("not interactable");
            }



        }
    }
}

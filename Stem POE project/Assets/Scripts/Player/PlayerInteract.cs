using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    public bool interactableSwitch = false;
    public bool flipped = false;
    public bool flipped1 = false;

    private Mushroom mushroom;
    private Mushroom1 mushroom1;
    private Mushroom2 mushroom2;
    private Mushroom3 mushroom3;
    private Mushroom4 mushroom4;
    private Camera cam;
    private Switch lever;

    //[SerializeField]
    //private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;

    public float range = 5f;
    public bool ableToBeInteracted = false;
    public int mushroomCount = 5;

    
    Vector3 spawnPoint = new Vector3(38.73f, 5.08f, 3.52f);

    [SerializeField]
   // private GameObject prefab = null; // assign Cube prefab to this in Editor

    // Start is called before the first frame update
    void Start()
    {
        lever = GameObject.Find("Lever Switch").GetComponent<Switch>();
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
        if(mushroomCount == 0)
        {
            SceneManager.LoadScene("WIN");
        }







        playerUI.UpdateText(string.Empty);
       

        Vector3 direction = Vector3.forward;
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * range);

        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            if (hit.collider.tag == "Switch" && flipped1 == false)
            {
                interactableSwitch = true;

                //Debug.Log("interactable");


                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("flipped");
                    flipped = true;



                }
                else interactableSwitch = false;
            }





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

                if (hit.collider.tag != "Mushroom")
                {
                    ableToBeInteracted = false;
                    //Debug.Log("not interactable");
                }



            }
        }

    }



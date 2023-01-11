using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool moved;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Mover());
    }

    // Update is called once per frame
    void Update()
    {
       // if (moved == false)
        //{
            
            
       // }
    }

    IEnumerator Mover()
    {
        transform.Translate(Vector3.right * 2);
        yield return new WaitForSeconds(0.05f);
        transform.Translate(Vector3.left * 2);
        yield return new WaitForSeconds(0.05f);
        StartCoroutine(Mover());
    }
}

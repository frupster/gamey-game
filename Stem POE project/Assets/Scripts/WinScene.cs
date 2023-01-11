using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScene : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip confettiNoise;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(confettiNoise);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}

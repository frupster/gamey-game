using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

   public TextMeshProUGUI itemCount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
        
        GetComponent<Mushroom>();
        GetComponent<Mushroom1>();
        GetComponent<Mushroom2>();
    }

    public void UpdateCount(string itemMessage)
    {
        itemCount.text = itemMessage;
    }
}

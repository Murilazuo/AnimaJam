using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowGameOverText : MonoBehaviour
{
    Text text;
    [TextArea][SerializeField] private string[] endText;
    void Start()
    {
        text = GetComponent<Text>();
        text.text = endText[GameManager.endId];
    }

    
}

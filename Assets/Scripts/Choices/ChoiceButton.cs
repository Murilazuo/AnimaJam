using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    public ChoiceData buttonChoiceData;
    [SerializeField] private Text text;
    ChoiceManager choiceManager;
    private void Start()
    {
        choiceManager = ChoiceManager.choiceManager;
        //text = GetComponentInChildren<Text>();
    }
    public void NewChoiceData(ChoiceData newChoiceData)
    {
        buttonChoiceData = newChoiceData;
        text.text = buttonChoiceData.choiceName;
    }

    public void Choose()
    {
        choiceManager.NewChoose(buttonChoiceData);
    }
}

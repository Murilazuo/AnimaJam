using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour
{
    public ChoiceData buttonChoiceData;
    [SerializeField] private Text text;
    ChoiceManager choiceManager;
    public Button button;
    private void Awake()
    {
        choiceManager = ChoiceManager.choiceManager;
        button = GetComponent<Button>(); 
    }
    public void NewChoiceData(ChoiceData newChoiceData)
    {
            buttonChoiceData = newChoiceData;
        if (choiceManager.money < buttonChoiceData.moneyRequired)
            button.interactable = false;
        else button.interactable = true;
            text.text = buttonChoiceData.choiceName;
    }

    public void Choose()
    {
        choiceManager.NewChoose(buttonChoiceData);
    }
}

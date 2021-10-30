using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public ChoiceData currentChoice;

    Text text;

    public static ChoiceManager choiceManager;
    private void Awake()
    {
        choiceManager = this;
    }
    private void OnDestroy()
    {
        choiceManager = null;
    }
    void Start()
    {
        text = GetComponent<Text>();
        NewChoose(currentChoice);
    }

    public void NewChoose(ChoiceData newChoice)
    {
        int i = 0;
        currentChoice = newChoice;
        text.text = currentChoice.choiceText;

        foreach (Transform choiceBtn in transform)
        {
            choiceBtn.GetComponent<ChoiceButton>().NewChoiceData(currentChoice.choices[i]);
            i++;
        }
    }
}

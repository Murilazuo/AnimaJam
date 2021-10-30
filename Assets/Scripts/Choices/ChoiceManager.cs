using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public ChoiceData currentChoice;
    [SerializeField] private float money = 10;
    
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
        int indexButton = 0;
        currentChoice = newChoice;
        money += newChoice.money;
        text.text = currentChoice.choiceText;
        GameObject.FindGameObjectWithTag("BackGround").GetComponent<Image>().sprite = currentChoice.backGround;

        foreach (Transform choiceBtn in transform)
        {
                choiceBtn.GetComponent<ChoiceButton>().NewChoiceData(currentChoice.choices[indexButton]);
                indexButton++;
        }
    }
}

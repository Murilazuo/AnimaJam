using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public ChoiceData currentChoice;
    public float money = 50;
    [SerializeField] private ChoiceButton[] choiceBtbs;
    
    Text text;

    public static ChoiceManager choiceManager;
    private void Awake()
    {
        choiceManager = this;
    }
    private void OnDestroy()
    {
        choiceManager = null;
        money = 50;
    }
    void Start()
    {
        text = GetComponent<Text>();
        NewChoose(currentChoice);
    }

    public void NewChoose(ChoiceData newChoice)
    {
        currentChoice = newChoice;

        switch (currentChoice.choices.Length)
        {
            case 1:
                choiceBtbs[0].gameObject.SetActive(false);
                choiceBtbs[1].gameObject.SetActive(true);
                choiceBtbs[2].gameObject.SetActive(false);
                break;
            case 2:
                choiceBtbs[0].gameObject.SetActive(true);
                choiceBtbs[1].gameObject.SetActive(false);
                choiceBtbs[2].gameObject.SetActive(true);
                break;
            case 3:
                choiceBtbs[0].gameObject.SetActive(true);
                choiceBtbs[1].gameObject.SetActive(true);
                choiceBtbs[2].gameObject.SetActive(true);
                break;
        }

        int indexButton = 0;
        money += newChoice.money;
        text.text = currentChoice.choiceText;
        GameObject.FindGameObjectWithTag("BackGround").GetComponent<Image>().sprite = currentChoice.backGround;
        
        foreach (Transform choiceBtn in transform)
        {
            if (choiceBtn.gameObject.activeSelf)
            {
                choiceBtn.GetComponent<ChoiceButton>().NewChoiceData(currentChoice.choices[indexButton]);
                indexButton++;
            }
        }
    }
}

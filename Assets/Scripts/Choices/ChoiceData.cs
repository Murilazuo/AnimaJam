using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newChoice", menuName = "Choice")]
public class ChoiceData : ScriptableObject
{
    [TextArea]public string choiceText;
    public string choiceName;
    public ChoiceData[] choices;
    public Sprite backGround;
    public float money;
    public float moneyRequired = 0;
}

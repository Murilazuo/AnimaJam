using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newChoice", menuName = "Choice")]
public class ChoiceData : ScriptableObject
{
    public string choiceText;
    public string choiceName;
    public ChoiceData[] choices;
    public Sprite backGround;
    public Sprite character;
}

[System.Serializable]
public struct TimelineVariable
{
    public int variable1;

}
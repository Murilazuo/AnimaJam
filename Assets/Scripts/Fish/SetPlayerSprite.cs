using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerSprite : MonoBehaviour
{
    public static Sprite playerSprite;
    void Start()
    {
        SetSprite();
    }

    void SetSprite()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null) return;

        GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite = playerSprite;
    }
    public void ChangeSprite(Sprite newSprite)
    {
        playerSprite = newSprite;
    }
}

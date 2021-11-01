using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;

    SpriteRenderer spr;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = sprites[Random.Range(0, sprites.Length - 1)];
    }

}

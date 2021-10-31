using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHungry : MonoBehaviour
{
    internal float hungry = 100;
    [SerializeField] private float hungryDecrease;
    [SerializeField] private float hungryBunus;
    [SerializeField] private Transform hungryBar;
    
    void Update()
    {
        if (hungry >= 100) hungry = 100;

        if(hungry <= 0)
        {
            GetComponent<FishMove>().speed = 0;
            GameManager.gameManager.GameOver(0);
        }else hungry -= hungryDecrease;

        hungryBar.localScale = new Vector2((hungry / 100) * 5, hungryBar.localScale.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food") && hungry < 100)
        {
            hungry += hungryBunus;
            Destroy(collision.gameObject);
        }
    }
}

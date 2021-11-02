using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishHungry : MonoBehaviour
{
    internal float hungry = 100;
    internal bool fim=false;
    [SerializeField] private float hungryDecrease;
    [SerializeField] private float hungryBunus;
    [SerializeField] private Transform hungryBar;
    FishSoundFX fishSoundFX;
    private void Start()
    {
        fishSoundFX = FishSoundFX.fishSoundFx;
    }

    void Update()
    {
        if (SpawnObstacle.stop) return;

        if(hungry <= 0)
        {
            GetComponent<FishMove>().speed = 0;
            if(fim==false){
                GameManager.gameManager.GameOver(0);
                fim=true;
            }
        }else hungry -= hungryDecrease;

        hungry = Mathf.Clamp(hungry, 0, 100);
        hungryBar.localScale = new Vector2((hungry / 100) * 5, hungryBar.localScale.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food") && hungry < 100)
        {
            fishSoundFX.PlayFoodFx();
            hungry += hungryBunus;
            Destroy(collision.gameObject);
        }
    }
}

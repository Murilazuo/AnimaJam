using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    [SerializeField] private float cameraLimitX, cameraLimitY;
    [SerializeField] private float speed = 200;
    [SerializeField] private float fishSpeedDecrease = 10;
    [SerializeField] private GameObject fishHook;
    Rigidbody2D rig;
    float inputX, inputY;

    SpawnObstacle spawnObstacle;
    SoundFish soundFish;
    public static FishMove fishMove;
    void Start()
    {
        fishMove = this;
        spawnObstacle = FindObjectOfType<SpawnObstacle>();
        rig = GetComponent<Rigidbody2D>();
        soundFish = GetComponent<SoundFish>();
    }
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");

        if (rig.position.x >= cameraLimitX && inputX > 0)
        {
            inputX = 0;
        }else if (rig.position.x <= -cameraLimitX && inputX < 0)
        {
            inputX = 0;
        }

        if (rig.position.y >= cameraLimitY && inputY > 0)
        {
            inputY = 0;
        }
        else if (rig.position.y <= -cameraLimitY && inputY < 0)
        {
            inputY = 0;
        }
    }
    internal void DecreaseSpeed()
    {
        if (spawnObstacle.stop == true) return;

        if (speed <= 60 && soundFish.idAudio == 1)
        {
            soundFish.StartCoroutine("SetAudioClip", 2);
        }else if (speed <= 120 && soundFish.idAudio == 0)
        {
            soundFish.StartCoroutine("SetAudioClip", 1);
        }
        speed -= fishSpeedDecrease;
        
        if (speed <= 0)
        {
            soundFish.StartCoroutine("StopAudio");
            speed = 0;
            Instantiate(fishHook, new Vector2(transform.position.x, 10), Quaternion.identity);
            spawnObstacle.stop = true;
        }
        
    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2( inputX * speed * Time.deltaTime, inputY * speed * Time.deltaTime);
    }

}

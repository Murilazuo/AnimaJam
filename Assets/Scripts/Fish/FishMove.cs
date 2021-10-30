using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    [SerializeField] private float cameraLimitX, cameraLimitY;
    [SerializeField] private float speed = 200;
    [SerializeField] private float fishSpeedDecrease = 10;
    Rigidbody2D rig;
    float inputX, inputY;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
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
        if (speed <= 0) return;
        
        speed -= fishSpeedDecrease;
    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2( inputX * speed * Time.deltaTime, inputY * speed * Time.deltaTime);
    }

}

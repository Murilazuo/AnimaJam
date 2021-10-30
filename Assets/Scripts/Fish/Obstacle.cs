using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rig;
    [SerializeField] private float speed = 5; 
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = Vector2.left * speed;
    }
    public void Stop()
    {
        rig.velocity = Vector2.zero;
    }
   
}

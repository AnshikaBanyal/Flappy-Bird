using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrenth;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource Fly;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true){
        
        myRigidbody.velocity = Vector2.up * FlapStrenth;
        Fly.Play();
        }
      if ( transform.position.y < -7 || transform.position.y > 7){
            logic.GameOver();
            birdIsAlive = false;
        }
            
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}

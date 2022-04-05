using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rigid;

    // A body is added to the character.
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // By clicking the mouse, the character moves upwards.
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigid.velocity = Vector2.up * velocity;
        }
    }
    
    // Character dies upon collision.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
    
}

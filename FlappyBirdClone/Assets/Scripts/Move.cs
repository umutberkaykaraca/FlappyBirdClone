 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    // Scrolls to the left.
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

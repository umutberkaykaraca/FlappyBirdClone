using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Collision with the object between the pipes increases the score.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}

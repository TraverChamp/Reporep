using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomCollectable : MonoBehaviour
{
    public ScriptScore score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        RepositionCollectible();
    }
    void RepositionCollectible()
    {
        float newX = Random.Range(-5, 5);
        float newY = Random.Range(-3, 3);
        Vector2 newPos = new Vector2(newX, newY);
        transform.position = newPos;
        score.AddScore();

    }
}

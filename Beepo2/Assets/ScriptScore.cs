using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptScore : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    private int score = 0;
    public void AddScore()
    {
        score++;
        scoretext.text = score.ToString();
    }
}

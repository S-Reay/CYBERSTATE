using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score;

    void Start()
    {
        score = 1;
    }
    private void Update()
    {
        if (score< 1)
        {
            score = 1;
        }
        else if (score > 13)
        {
            score = 13;
        }
    }
}

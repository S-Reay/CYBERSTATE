using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    public ScoreTracker ScoreTracker;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WalkingBot")
        {
            Destroy(collision.gameObject);
            ScoreTracker.score++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserShotBehaviour : MonoBehaviour
{
    public float velocity;

    private void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            other.gameObject.GetComponent<FlyingBotActions>().Die();
            GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreTracker>().score--;
        }
        Destroy(gameObject);
    }
}

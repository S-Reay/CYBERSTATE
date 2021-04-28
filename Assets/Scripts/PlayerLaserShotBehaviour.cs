using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserShotBehaviour : MonoBehaviour
{
    public float velocity;
    public GameObject sparkParticle;

    private void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "FlyingBot")
        {
            other.gameObject.GetComponent<FlyingBotActions>().Die();
            GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreTracker>().score++;
        }
        else if (other.gameObject.transform.tag == "BossBot")
        {
            other.gameObject.GetComponent<BossBotActions>().Damage();
            Instantiate(sparkParticle, transform.transform.transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}

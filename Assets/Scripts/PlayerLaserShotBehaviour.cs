using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserShotBehaviour : MonoBehaviour
{
    public float velocity;

    private void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "FlyingBot")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}

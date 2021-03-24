using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlyingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject intendedExit;
    public GameObject flyingBotPrefab;

    public float spawnDelay;

    void Start()
    {
        StartCoroutine(timerLoop());
    }

    IEnumerator timerLoop()
    {
        yield return new WaitForSeconds(Random.Range(4f, 8f));
        Spawn();
        StartCoroutine(timerLoop());
    }
    void Spawn()
    {
        GameObject lastSpawned = Instantiate(flyingBotPrefab, transform.position, transform.rotation);
        lastSpawned.GetComponent<FlyingBotActions>().destination = intendedDestination.transform;
        lastSpawned.GetComponent<FlyingBotActions>().exitPoint = intendedExit.transform;
    }
}

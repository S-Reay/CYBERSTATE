using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalkingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject walkingBotPrefab;

    public float spawnDelay;

    void Start()
    {
        StartCoroutine(timerLoop());
    }

    IEnumerator timerLoop()
    {
        yield return new WaitForSeconds(Random.Range(6f, 12f));
        Spawn();
        StartCoroutine(timerLoop());
    }
    void Spawn()
    {
        GameObject lastSpawned = Instantiate(walkingBotPrefab, transform.position, transform.rotation);
        lastSpawned.GetComponent<WalkingBotActions>().destination = intendedDestination.transform;
    }
}

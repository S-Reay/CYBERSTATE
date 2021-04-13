using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlyingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject intendedExit;
    public GameObject flyingBotPrefab;

    public int[] spawnRates = new int[92];
    private int curentBeat = 0;

    public void Beat()
    {
        curentBeat++;
        if (spawnRates[curentBeat] > 0)
        {
            Spawn();
        }
    }
    void Spawn()
    {
        GameObject lastSpawned = Instantiate(flyingBotPrefab, transform.position, transform.rotation);
        lastSpawned.GetComponent<FlyingBotActions>().destination = intendedDestination.transform;
        lastSpawned.GetComponent<FlyingBotActions>().exitPoint = intendedExit.transform;
    }
}

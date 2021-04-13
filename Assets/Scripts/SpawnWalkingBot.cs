using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalkingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject walkingBotPrefab;

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

    public void Spawn()
    {
        GameObject lastSpawned = Instantiate(walkingBotPrefab, transform.position, transform.rotation);
        lastSpawned.GetComponent<WalkingBotActions>().destination = intendedDestination.transform;
    }
}

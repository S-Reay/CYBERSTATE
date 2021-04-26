using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnWalkingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject walkingBotPrefab;
    public ScoreTracker scoreTracker;


    public int[] spawnRates = new int[428];
    private int currentBeat = 0;
    public void UpdateSpawnRates(int[] newRates)
    {
        spawnRates = newRates;
    }

    public void Beat()
    {
        currentBeat++;
        if (spawnRates[currentBeat] > 0 && spawnRates[currentBeat] <= scoreTracker.score)
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

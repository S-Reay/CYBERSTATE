using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnWalkingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject walkingBotPrefab;

    public Text debugText;

    public int[] spawnRates = new int[428];
    private int curentBeat = 0;
    public void UpdateSpawnRates(int[] newRates)
    {
        spawnRates = newRates;
    }

    public void Beat()
    {
        curentBeat++;
        debugText.text = "Walking Beats: " + curentBeat;
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

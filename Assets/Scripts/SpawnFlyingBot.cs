using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFlyingBot : MonoBehaviour
{
    public GameObject intendedDestination;
    public GameObject intendedExit;
    public GameObject flyingBotPrefab;

    public Text debugText;

    public int[] spawnRates = new int[428];
    private int currentBeat = 0;

    public void UpdateSpawnRates(int[] newRates)
    {
        spawnRates = newRates;
    }

    public void Beat()
    {
        currentBeat++;
        debugText.text = currentBeat.ToString();
        if (spawnRates[currentBeat] > 0)
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

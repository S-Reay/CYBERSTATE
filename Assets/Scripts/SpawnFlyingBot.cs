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
    private int curentBeat = 0;

    public void UpdateSpawnRates(int[] newRates)
    {
        spawnRates = newRates;
    }

    public void Beat()
    {
        curentBeat++;
        debugText.text = "Flying Beats: " + curentBeat;
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

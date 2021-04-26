using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    public float bpm;
    private float beatInterval, beatTimer, beatInterval8, beatTimer8;
    public bool beatFull, beat8;
    public int beatCountFull, beatCount8;

    public SpawnWalkingBot SpawnWalkLeft, SpawnWalkRight;
    public SpawnFlyingBot SpawnFlyLeft, SpawnFlyRight;
    public GameObject bossBot;

    private void Update()
    {
        BeatDetection();
    }

    void BeatDetection()
    {
        if (beatCountFull == 427)
        {
            return;
        }
        //Full beat count
        beatFull = false;
        beatInterval = 60 / bpm;
        beatTimer += Time.deltaTime;
        if (beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatFull = true;
            beatCountFull++;
            SpawnWalkLeft.Beat();
            SpawnWalkRight.Beat();
            SpawnFlyLeft.Beat();
            SpawnFlyRight.Beat();
            if (beatCountFull == 102)   //Update BPM on song transition
            {
                bpm = 112;
            }
            if (beatCountFull == 50)    //TODO remove
            {
                bossBot.SetActive(true);
            }
        }
        //Divided beat count
        beat8 = false;
        beatInterval8 = beatInterval / 8;
        beatTimer8 += Time.deltaTime;
        if (beatTimer8 >= beatInterval8)
        {
            beatTimer8 -= beatInterval8;
            beat8 = true;
            beatCount8++;
            //Debug.Log("D8");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;

public class LaserPistol : MonoBehaviour
{
    public float shootRate;
    private float shootRateTimeStamp;

    public GameObject shotPrefab;
    public GameObject firePoint;

    void Update()
    {

        if (VRDevice.Device.GetButtonDown(VRButton.Trigger))                                                        //If the player pulls the trigger
        {
            if (Time.time > shootRateTimeStamp)                                                                     //If the gun is ready to shoot
            {
                shootRay();                                                                                         //Shoot
                shootRateTimeStamp = Time.time + shootRate;                                                         //Reset timer
            }
        }

    }

    void shootRay()
    {
        GameObject laser = Instantiate(shotPrefab, firePoint.transform.position, firePoint.transform.rotation);     //Spawn laser shot
        Destroy(laser, 8f);                                                                                         //Destory laser shot after 8 seconds
    }
}
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

    RaycastHit hit;
    float range = 1000.0f;


    void Update()
    {

        if (VRDevice.Device.PrimaryInputDevice.GetButtonDown(VRButton.Trigger))
        {
            if (Time.time > shootRateTimeStamp)
            {
                shootRay();
                shootRateTimeStamp = Time.time + shootRate;
            }
        }

    }

    void shootRay()
    {
        Ray ray = new Ray(firePoint.transform.position, firePoint.transform.forward);
        if (Physics.Raycast(ray, out hit, range))
        {
            GameObject laser = Instantiate(shotPrefab, firePoint.transform.position, firePoint.transform.rotation);
            laser.GetComponent<ShotBehavior>().setTarget(hit.point, hit.transform.gameObject);
            GameObject.Destroy(laser, 8f);
        }

    }
}
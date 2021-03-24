using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

	public GameObject projectileShot;
	public float shootForce = 0f;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject projectile = (GameObject)Instantiate(projectileShot, transform.position, transform.rotation);
			projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
		}
    }
}

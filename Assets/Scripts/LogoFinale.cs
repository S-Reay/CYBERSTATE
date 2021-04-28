using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoFinale : MonoBehaviour
{
    public GameObject destination;
    public float moveSpeed;
    void Update()
    {
        if (Vector3.Distance(transform.position, destination.transform.position) > 0.1f)
        {
            transform.position += -transform.up * moveSpeed * Time.deltaTime;
        }
    }
}

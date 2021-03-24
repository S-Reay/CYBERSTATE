using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private Camera player;

    private void Start()
    {
        player = Camera.main;
    }
    void Update()
    {
        transform.LookAt(player.transform);
    }
}

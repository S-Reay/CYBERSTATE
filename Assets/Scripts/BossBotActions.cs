using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBotActions : MonoBehaviour
{
    public int hp;
    public float speed;
    public GameObject destination;

    void Update()
    {
        if (hp > 0){Move();}
        if (Vector3.Distance(transform.position, destination.transform.position) > 0.1f)
        {
            Move();
        }
    }
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, speed * Time.deltaTime);
    }
    public void Damage()
    {
        //Flash red
        hp--;
        if (hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
        //Expolode
        //Large smoke effect
        //Call game ending
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBotActions : MonoBehaviour
{
    public int hp;
    public float speed;
    public GameObject destination;
    public GameObject explosionPrefab;
    public GameObject logo;

    void Update()
    {
        if (hp > 0){Move();}
        if (Vector3.Distance(transform.position, destination.transform.position) > 0.1f)
        {
            Move();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Die();
        }
    }
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, speed * Time.deltaTime);
    }
    public void Damage()
    {
        hp--;
        if (hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        logo.SetActive(true);
        Destroy(gameObject);
    }
}

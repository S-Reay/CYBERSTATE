using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBotActions : MonoBehaviour
{
    public Transform destination;
    public Transform exitPoint;
    public float acceptableDistance;
    public float speed;

    public GameObject shotPrefab;
    public GameObject firePoint;
    public GameObject explosionPrefab;
    public GameObject modelPrefab;
    private GameObject targerPoint;
    private GameObject player;

    public bool hasFired = false;
    public bool isExiting = false;

    void Start()
    {
        targerPoint = GameObject.FindGameObjectWithTag("EnemyTargetPoint");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (!hasFired)
        {
            if (Vector3.Distance(transform.position, destination.position) > acceptableDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);
            }
            else
            {
                hasFired = true;
                StartCoroutine(CountdownToAttack());
            }
        }
        if (isExiting)
        {
            if (Vector3.Distance(transform.position, exitPoint.position) > acceptableDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, exitPoint.position, speed * Time.deltaTime);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }
    IEnumerator CountdownToAttack()
    {
        yield return new WaitForSeconds(.25f);
        Attack();
    }
    void Attack()
    {
        GameObject laser = Instantiate(shotPrefab, firePoint.transform.position, firePoint.transform.rotation);
        laser.GetComponent<ShotBehavior>().setTarget(targerPoint.transform.position, player);
        StartCoroutine(CountdownToExit());
    }
    IEnumerator CountdownToExit()
    {
        yield return new WaitForSeconds(.25f);
        isExiting = true;
        gameObject.GetComponent<LookAtPlayer>().enabled = false;
    }
    public void Die()
    {
        explosionPrefab.SetActive(true);
        modelPrefab.SetActive(false);
        Destroy(gameObject, 2f);
    }
}

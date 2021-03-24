using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingBotActions : MonoBehaviour
{
    public Animator animator;
    public Transform destination;
    public float acceptableDistance;
    public float walkSpeed;
    public bool hasAttacked = false;
    public bool isDead = false;
    public GameObject explosionPrefab;

    private void Update()
    {
        if (!isDead)
        {
            if (!hasAttacked)
            {
                if (Vector3.Distance(transform.position, destination.position) < acceptableDistance)
                {
                    animator.SetBool("isExploding", true);
                    hasAttacked = true;
                    StartCoroutine(CountdownToAttack());
                }
                else
                {
                    transform.position += transform.forward * walkSpeed * Time.deltaTime;
                }
            }

        }
    }
    IEnumerator CountdownToAttack()
    {
        yield return new WaitForSeconds(2f);
        Attack();
    }
    void Attack()
    {
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 3f);
            Destroy(gameObject);
        }
    }
    public void Die()
    {
        StopAllCoroutines();
        Destroy(gameObject, 3f);
    }
}

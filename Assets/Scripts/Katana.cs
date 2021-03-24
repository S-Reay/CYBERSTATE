using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WalkingBot")
        {
            Destroy(collision.gameObject);
            //if (collision.transform.root.GetComponent<Animator>() != null)
            //{
            //    collision.transform.root.GetComponent<Animator>().enabled = false;
            //}
            //if (collision.transform.root.GetComponent<WalkingBotActions>() != null)
            //{
            //    collision.transform.root.GetComponent<WalkingBotActions>().Die();
            //}
        }
    }
}

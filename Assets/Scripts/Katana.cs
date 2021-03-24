using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.root.tag == "WalkingBot")
        {
            if (collision.transform.root.GetComponent<Animator>() != null)
            {
                collision.transform.root.GetComponent<Animator>().enabled = false;
            }
            if (collision.transform.root.GetComponent<WalkingBotActions>() != null)
            {
                collision.transform.root.GetComponent<WalkingBotActions>().Die();
            }
        }
    }
}

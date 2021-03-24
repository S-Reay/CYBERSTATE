using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour
{

    public Vector3 m_target;
    public GameObject collisionExplosion;
    public float speed;
    public GameObject m_hitObject;


    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward * Time.deltaTime * 300f;// The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        if (m_target != null)
        {
            if (transform.position == m_target)
            {
                explode();
                return;
            }
            transform.position = Vector3.MoveTowards(transform.position, m_target, step);
        }

    }

    public void setTarget(Vector3 target, GameObject hitObject)
    {
        m_target = target;
        m_hitObject = hitObject;
    }

    void explode()
    {
        if (collisionExplosion != null)
        {
            if (m_hitObject.tag == "FlyingBot")
            {
                Destroy(m_hitObject);
            }
            if (m_hitObject.tag != "Player")
            {
                GameObject explosion = Instantiate(collisionExplosion, transform.position, transform.rotation);
                Destroy(explosion, 3f);
            }
            Destroy(gameObject);

        }
    }

}
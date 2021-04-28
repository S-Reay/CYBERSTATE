using UnityEngine;

public class SelfRemove : MonoBehaviour
{
    public float timer;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}

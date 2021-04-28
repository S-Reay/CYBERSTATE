using UnityEngine;

public class SelfRemove : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }
}

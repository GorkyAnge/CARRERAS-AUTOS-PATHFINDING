using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float seconds = 1f;

    void Start()
    {
        Destroy(gameObject, seconds);
    }
}

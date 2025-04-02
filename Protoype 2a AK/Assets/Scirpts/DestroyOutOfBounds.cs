using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 50;
    public float bottomBound = -20;

// Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
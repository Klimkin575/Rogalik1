using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}

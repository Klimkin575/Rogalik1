using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void SetTarget(Transform targetPlayer)
    {
        target = targetPlayer;
    }
}

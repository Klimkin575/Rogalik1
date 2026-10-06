using UnityEngine;

public class FlyAnim : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public Vector2 dir;

    void Update()
    {
        dir = player.position - transform.position;

        animator.SetFloat("Dirx", dir.x);
        animator.SetFloat("Diry", dir.y);
    }

    public void SetTarget(Transform target)
    {
        player = target;
    }
}

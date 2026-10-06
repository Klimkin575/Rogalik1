using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    public Animator animator;
    public Transform player;

    private Vector2 dir;

    private void Update()
    {
        dir = player.position - transform.position;
        dir.Normalize();

        animator.SetFloat("Dirx",dir.x);
        animator.SetFloat("Diry",dir.y);
    }

    public void SetTarget(Transform targetPlayer)
    {
        player = targetPlayer;
    }
}

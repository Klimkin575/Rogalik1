using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public Animator animator;
    public float destroyTime;
    public EnemyMover enemyMover;
    public EnemyFlyMover flyMover;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health == 0)
        {
            EnemyRandom.deadEnemy ++;
            if (enemyMover != null)
                enemyMover.speed = 0;
            if (flyMover != null)
                flyMover.speed = 0;
            animator.SetTrigger("Die");
            Destroy(gameObject, destroyTime);
        }
    }
}

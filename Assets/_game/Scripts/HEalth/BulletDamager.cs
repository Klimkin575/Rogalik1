using UnityEngine;

public class BulletDamager : MonoBehaviour
{
    public int damage;
    public bool enemyBullet;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (enemyBullet && collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
        else if (!enemyBullet && collision.gameObject.TryGetComponent(out EnemyHealth enemy))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

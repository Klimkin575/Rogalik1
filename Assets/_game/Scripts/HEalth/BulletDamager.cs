using UnityEngine;

public class BulletDamager : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyHealth enemy))
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

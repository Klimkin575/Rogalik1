using UnityEngine;

public class EnemyFlyMover : MonoBehaviour
{
    public float speed;
    public SpriteRenderer area;
    public Vector2 target;
    public Transform player;
    public GameObject bullet;
    public float shootInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(Shoot), shootInterval, shootInterval);
    }

    void Update()
    {
        if ((Vector2)transform.position == target)
            target = new Vector2(Random.Range(area.bounds.min.x, area.bounds.max.x), Random.Range(area.bounds.min.y, area.bounds.max.y));

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x) * Mathf.Rad2Deg)).GetComponent<BulletDamager>().enemyBullet = true;
    }

    public void SetTarget(SpriteRenderer sprite, Transform playerTarget)
    {
        area = sprite;
        target = transform.position;
        player = playerTarget;
    }
}

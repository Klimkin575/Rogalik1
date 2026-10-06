using UnityEngine;

public class EnemyFlyMover : MonoBehaviour
{
    public float speed;
    public SpriteRenderer area;
    public Vector2 target;

    void Update()
    {
        if ((Vector2)transform.position == target)
            target = new Vector2(Random.Range(area.bounds.min.x, area.bounds.max.x), Random.Range(area.bounds.min.y, area.bounds.max.y));
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    public void SetTarget(SpriteRenderer sprite)
    {
        area = sprite;
    }
}
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class SpeedBoster : MonoBehaviour
{
    public PlayerMover playerMover;
    public float speedBoost;
    public float sec;

    private SpriteRenderer sprite;
    private BoxCollider2D box;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
        {
            StartCoroutine(ApplySpeedBoost(player));
        }
    }

    public IEnumerator ApplySpeedBoost(PlayerMover playerMover)
    {
        playerMover.speed += speedBoost;
        sprite.enabled = false;
        box.enabled = false;
        yield return new WaitForSeconds(sec);
        playerMover.speed -= speedBoost;
        Destroy(gameObject);
    }
}
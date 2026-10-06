using System.Collections;
using UnityEngine;

public class EnemyMelleAttack : MonoBehaviour
{
    public Animator animator;
    public float attSpeed;

    private Coroutine coroutine;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
          coroutine = StartCoroutine(Attack(player));
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth player))
        {
            StopCoroutine(coroutine);
        }
    }

    private IEnumerator Attack(PlayerHealth player)
    {
        while (true)
        {
            animator.SetTrigger("Attack");
            player.TakeDamage(1);
            yield return new WaitForSeconds(attSpeed);
        }
    }
}

using UnityEngine;

public class Medkit : MonoBehaviour
{
    public int heal = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerHealth player))
        {
            player.AddHealth(heal);
            Destroy(gameObject);
        }
    }
}

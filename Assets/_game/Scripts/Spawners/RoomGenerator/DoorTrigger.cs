using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Transform krygo4ec;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
        {
            player.transform.position = krygo4ec.position;
        }
    }
}

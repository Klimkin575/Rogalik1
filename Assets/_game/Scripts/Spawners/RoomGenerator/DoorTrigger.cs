using System.Collections;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Room room;
    public Collider2D trigger;
    public float moveTime = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
            StartCoroutine(MovePlayer(player));
    }

    private IEnumerator MovePlayer(PlayerMover player)
    {
        trigger.enabled = false;
        player.enabled = false;
        player.dir = Vector2.zero;
        player.body2D.simulated = false;

        Vector3 startPosition = player.transform.position;
        float time = 0;

        room.frontDoor.connectDoor.GetComponentInParent<Room>().roomCamera.Priority = room.roomCamera.Priority + 1;

        while (time < moveTime)
        {
            time += Time.deltaTime;
            player.transform.position = Vector3.Lerp(startPosition, room.frontDoor.connectDoor.playerPoint.position, time / moveTime);
            yield return null;
        }

        player.transform.position = room.frontDoor.connectDoor.playerPoint.position;
        player.body2D.position = room.frontDoor.connectDoor.playerPoint.position;
        player.body2D.simulated = true;
        room.frontDoor.connectDoor.gameObject.SetActive(true);
        room.frontDoor.connectDoor.GetComponentInParent<Room>().enemyRandom.StartRoom(player.transform);
        player.enabled = true;
    }
}

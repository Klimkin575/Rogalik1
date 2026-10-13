using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public int counter;
    public Room startRoom;
    public Room roomPrefab;
    public Transform player;

    void Start()
    {
        Room currentRoom = startRoom;

        for (int i = 0; i < counter; i++)
        {
            Room newRoom = Instantiate(roomPrefab);
            newRoom.enemyRandom.bossRoom = (i + 2) % 5 == 0;

            newRoom.transform.position += currentRoom.frontDoor.transform.position - newRoom.backDoor.transform.position;
            currentRoom.frontDoor.connectDoor = newRoom.backDoor;
            currentRoom = newRoom;
        }

        startRoom.roomCamera.Priority = 20;
        startRoom.enemyRandom.StartRoom(player);
    }
}

using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public int counter;
    public Room startRoom;
    public Room roomPrefab;

    void Start()
    {
        Room currentRoom = startRoom;

        for (int i = 0; i < counter; i++)
        {
            Room newRoom = Instantiate(roomPrefab);

            Vector3 distance = currentRoom.frontDoor.transform.position - newRoom.backDoor.transform.position;

            newRoom.transform.position += distance;
            currentRoom.backDoor.connectDoor = currentRoom.frontDoor;
            currentRoom = newRoom;
        }
    }
}

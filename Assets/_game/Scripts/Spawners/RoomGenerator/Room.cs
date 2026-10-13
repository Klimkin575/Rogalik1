using UnityEngine;
using Cinemachine;

public class Room : MonoBehaviour
{
    public Door frontDoor;
    public Door backDoor;
    public EnemyRandom enemyRandom;
    public DoorTrigger transitionTrigger;
    public CinemachineVirtualCamera roomCamera;
}

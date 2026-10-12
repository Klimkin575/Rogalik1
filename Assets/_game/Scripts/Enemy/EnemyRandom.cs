using UnityEngine;

public class EnemyRandom : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoints;
    public bool bossRoom;
    public GameObject boss;
    public SpriteRenderer sprite;
    public Room room;
    public int deadEnemy;
    public int enemyCount;

    public void StartRoom(Transform player)
    {
        room.transitionTrigger.trigger.enabled = false;
        enemyCount = bossRoom ? 1 : Random.Range(2, 5);

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemyObject = Instantiate(
                bossRoom ? boss : enemy[Random.Range(0, enemy.Length)],
                spawnPoints[Random.Range(0, spawnPoints.Length)].position,
                Quaternion.identity
            );

            enemyObject.GetComponent<EnemyHealth>().room = this;

            if (enemyObject.TryGetComponent(out EnemyMover mover))
                mover.SetTarget(player);

            if (enemyObject.TryGetComponent(out EnemyAnim anim))
                anim.SetTarget(player);

            if (enemyObject.TryGetComponent(out EnemyFlyMover flyMover))
                flyMover.SetTarget(sprite, player);

            if (enemyObject.TryGetComponent(out FlyAnim flyAnim))
                flyAnim.SetTarget(player);
        }
    }

    public void EnemyDied()
    {
        deadEnemy++;

        if (deadEnemy == enemyCount)
        {
            if (room.frontDoor.connectDoor == null)
                Debug.Log("win");
            else
            {
                room.frontDoor.gameObject.SetActive(false);
                room.transitionTrigger.trigger.enabled = true;
            }
        }
    }
}

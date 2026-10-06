using UnityEngine;

public class EnemyRandom : MonoBehaviour
{
    public GameObject[] enemy;
    public GameObject[] gates;
    public Transform[] spawnPoints;
    public bool bossRoom = false;
    public GameObject boss;
    public Transform targetPlayer;
    public SpriteRenderer sprite;
    public static int deadEnemy;

    private int randomPoint;
    private int randomEnemy;
    private int randomCount;

    void Start()
    {
        randomCount = Random.Range(2, 5);
        if (bossRoom)
        {
            int randomPoint = Random.Range(0, spawnPoints.Length);
            GameObject enemyObject = Instantiate(boss, spawnPoints[randomPoint].position, Quaternion.identity);
            if (enemyObject.TryGetComponent(out EnemyMover mover))
            {
                mover.SetTarget(targetPlayer);
            }
            if (enemyObject.TryGetComponent(out EnemyAnim anim))
            {
                anim.SetTarget(targetPlayer);
            }
            return;
        }

        for (int i = 0; i < randomCount; i++)
        {
            for (int counter = 0; counter < 5; counter++)
            {
                randomPoint = Random.Range(0, 5);
                randomEnemy = Random.Range(0, enemy.Length);

                if (randomPoint == counter)
                {
                    GameObject enemyObject = Instantiate(enemy[randomEnemy], spawnPoints[randomPoint].position, Quaternion.identity);

                    if (enemyObject.TryGetComponent(out EnemyMover mover))
                    {
                        mover.SetTarget(targetPlayer);
                    }
                    if (enemyObject.TryGetComponent(out EnemyAnim anim))
                    {
                        anim.SetTarget(targetPlayer);
                    }
                    if (enemyObject.TryGetComponent(out EnemyFlyMover flyMover))
                    {
                        flyMover.SetTarget(sprite);
                    }
                    if (enemyObject.TryGetComponent(out FlyAnim flyAnim))
                    {
                        flyAnim.SetTarget(targetPlayer);
                    }
                }
            }

        }
    }

    private void Update()
    {
        if (deadEnemy == randomCount)
        {
            for (int i = 0; i < gates.Length; i++)
            {
                gates[i].SetActive(false);
            }
        }
    }
}

using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items;
    public Transform[] spawnPoints;

    private int randomPoint;
    private int randomItem;
    private int randomCount;

    void Start()
    {
        randomCount = Random.Range(1, 5);

        for (int i = 0; i < randomCount; i++)
        {
            for (int counter = 0; counter < 5; counter++)
            {
                randomPoint = Random.Range(0, 5);
                randomItem = Random.Range(0, 3);

                if (randomPoint == counter)
                {
                    Instantiate(items[randomItem], spawnPoints[randomPoint].position, Quaternion.identity);
                }
            }

        }
    }
}

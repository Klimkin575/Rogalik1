using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyHealth enemy;
    public int enemyCount;
    public float sec;

    IEnumerator Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(sec);
        }
    }
}

using UnityEngine;

public class EnemyActivator : MonoBehaviour
{
    public GameObject[] enemies;

    void Start()
    {
        for (int i = 0; i < enemies.Length; i += 2)
        {
            if (enemies[i] != null)
                enemies[i].SetActive(true);
        }
    }
}
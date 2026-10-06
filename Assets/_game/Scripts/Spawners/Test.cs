using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] hollo;

    private int randomCount;

    void Start()
    {
        randomCount = Random.Range(0, hollo.Length);
        for (int i = 0; i < hollo.Length; i++)
        {
            if (i == 2)
            {
                print(hollo[i]);
            }
        }

        for (int i = 0;i < hollo.Length; i++)
        {
            if (i == randomCount)
            {
                print(hollo[i]);
            }
        }
    }
}
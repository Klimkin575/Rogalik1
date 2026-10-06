using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public Camera cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = mousePosition - (Vector2)transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Instantiate(bullet, transform.position, Quaternion.Euler(0f, 0f, angle));
        }
    }
}
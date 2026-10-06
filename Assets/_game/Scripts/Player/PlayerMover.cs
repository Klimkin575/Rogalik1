using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body2D;
    public Vector2 dir;

    void Update()
    {
       dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized; 
    }

    private void FixedUpdate()
    {
        body2D.MovePosition(body2D.position + dir * speed * Time.fixedDeltaTime);
    }
}

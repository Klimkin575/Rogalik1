using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;
    public Camera cam;

    private Vector2 front = Vector2.down;
    private Vector2 move;
    private Vector2 aim;
 
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        aim = cam.ScreenToWorldPoint(Input.mousePosition)-transform.position;

        if (Vector2.Distance(aim, transform.position) > 0)
        {
            front = aim.normalized;
        }

        anim.SetBool("IsMove", move.sqrMagnitude > 0);
        anim.SetFloat("Velx", front.x);
        anim.SetFloat("Vely", front.y);
        anim.SetFloat("Idlex", front.x);
        anim.SetFloat("Idley", front.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 250f;

    private Animator animator;
    private Rigidbody2D body;
    private Collider2D collider;

    private bool isRun = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;

        isRun = Mathf.Abs(dx) >= 0.2;
        animator.SetBool("isRun", isRun);

        if (dx < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (dx > 0)
            transform.localScale = new Vector3(1, 1, 1);

        bool grounde = false;
        Vector3 max = collider.bounds.max;
        Vector3 min = collider.bounds.min;
        Vector2 point1 = new Vector2(max.x - 0.1f, min.y - 0.1f);
        Vector2 point2 = new Vector2(min.x + 0.1f, min.y - 0.1f);
        Collider2D hit = Physics2D.OverlapArea(point1, point2);

        if (hit != null)
            grounde = true;

        if (grounde && Input.GetKeyDown(KeyCode.Space))
            body.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

        body.velocity = new Vector2(dx, body.velocity.y);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 5;
    Vector2 move;
    public bool CanMove = true;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!CanMove)
        return;

        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", move.x);
        anim.SetFloat("Vertical", move.y);
        anim.SetFloat("speed", move.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        if(!CanMove)
        return;
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}

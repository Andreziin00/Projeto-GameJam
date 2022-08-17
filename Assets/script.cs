using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour;

    public float jumpForce;
    private bool doubleJump, isJump, isGround;
    private Transform groudcheck;
    private RigidBody2D rb;

{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<RigidBody2D> ();
        groundcheck = GameObject.Find ("groundcheck").transform;
    }

    void
    // Update is called once per frame
    void Update()
    {
        
    }
}

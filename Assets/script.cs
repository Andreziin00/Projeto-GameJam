using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    //public float jumpForce;
    private bool doubleJump, isJump, isGround;
    private Transform groudcheck;
    private Rigidbody2D rb;
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groudcheck = GameObject.Find ("groundcheck").transform;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

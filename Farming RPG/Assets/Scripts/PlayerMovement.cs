using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D rb;

    private float x;
    private float y;

    private Vector2 input;

    public VectorValue startingPosition;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = startingPosition.initialValue;
    }
    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        rb.velocity = input * moveSpeed;
    }

    private void GetInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        input = new Vector2(x, y);
        input.Normalize();
    }

}

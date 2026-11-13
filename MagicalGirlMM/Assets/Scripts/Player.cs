using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 movementInput;


    public float walkSpeed, walkAcceleration, walkDecceleration;
    Rigidbody2D rb;
    Vector2 walk;

    public bool friction = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        walk = movementInput.normalized * walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        //MOVEMENT SYSTEM 

        rb.linearVelocity -= walk;

        walk = movementInput.normalized * walkSpeed;

        if (friction)
        {
            rb.linearVelocity *= walkDecceleration;
        }

        rb.linearVelocity += walk;
    }

    public void GetMoveInput(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 movementInput;
  

    public float walkSpeed, walkAcceleration, walkDecceleration;
    Rigidbody2D rb;
    Vector2 walk;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        walk = movementInput.normalized * walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

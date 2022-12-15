using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    [SerializeField] int moveAmount;

    Rigidbody2D rb;
    Vector2 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            MoveBallUp();
        }
    }

    private void MoveBallUp()
    {
        rb.velocity = Vector2.up * moveAmount;
    }
}
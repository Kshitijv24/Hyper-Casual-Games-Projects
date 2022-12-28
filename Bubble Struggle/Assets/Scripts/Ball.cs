using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] int forceAmount;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * forceAmount);
    }
}

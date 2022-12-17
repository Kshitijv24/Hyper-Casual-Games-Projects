using UnityEngine;

public class SmallCircleChild : MonoBehaviour
{
    PolygonCollider2D polygonCollider2D;

    private void Start()
    {
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == this.gameObject.tag)
        {
            polygonCollider2D.isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != this.gameObject.tag)
        {
            polygonCollider2D.isTrigger = false;
        }
    }
}

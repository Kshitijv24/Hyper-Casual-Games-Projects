using UnityEngine;

public class ColorChangeBall : MonoBehaviour
{
    [SerializeField] Color[] colors;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color = spriteRenderer.color;
        //collision.gameObject.tag = 
    }
}

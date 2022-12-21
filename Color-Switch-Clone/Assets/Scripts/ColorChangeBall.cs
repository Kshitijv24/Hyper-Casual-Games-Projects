using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorChangeBall : MonoBehaviour
{
    [SerializeField] Color[] colors;
    [SerializeField] SpriteRenderer ballSpriteRenderer;
    [SerializeField] GameObject smallCirclePrefab;
    [SerializeField] Transform nextSpawnPoint;

    SpriteRenderer spriteRenderer;
    Color currentColor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentColor = colors[Random.Range(0, colors.Length)];
        spriteRenderer.color = currentColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnNextCircle();
        SwitchBallTagAndColor(collision);
        Destroy(gameObject);
    }

    private void SwitchBallTagAndColor(Collider2D collision)
    {
        if(currentColor == colors[0])
        {
            collision.gameObject.tag = "Blue";
            ballSpriteRenderer.color = colors[0];
        }
        else if (currentColor == colors[1])
        {
            collision.gameObject.tag = "Yellow";
            ballSpriteRenderer.color = colors[1];
        }
        else if (currentColor == colors[2])
        {
            collision.gameObject.tag = "Pink";
            ballSpriteRenderer.color = colors[2];
        }
        else if (currentColor == colors[3])
        {
            collision.gameObject.tag = "Purple";
            ballSpriteRenderer.color = colors[3];
        }
    }

    private void SpawnNextCircle()
    {
        Instantiate(smallCirclePrefab, nextSpawnPoint.position, transform.rotation);
    }
}

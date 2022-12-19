using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject smallCirclePrefab;

    private void Update()
    {
        FollowPlayerUp();
    }

    private void FollowPlayerUp()
    {
        if (player.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(smallCirclePrefab);
    }
}

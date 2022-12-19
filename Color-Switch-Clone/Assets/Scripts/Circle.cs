using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] int rotationSpeed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.deltaTime);
    }
}

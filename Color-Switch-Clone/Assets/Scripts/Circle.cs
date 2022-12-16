using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] int rotationSpeed;
    //[SerializeField] GameObject target;

    private void Start()
    {
        
    }

    private void Update()
    {
        //transform.RotateAround(target.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.deltaTime);
    }
}

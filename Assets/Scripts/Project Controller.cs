using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectController : MonoBehaviour
{
    public Vector2 directionalInput;
    public GameObject prefab;

    private Vector3 worldMousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = worldMousePosition - transform.position;
    }

    public void OnLook (InputAction.CallbackContext context)
    {
        transform.up = worldMousePosition - transform.position;
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        GameObject spawnedObject = Instantiate(prefab, transform.position, Quaternion.identity);
        if (spawnedObject)
        {
            transform.position = spawnedObject.transform.position * Time.deltaTime;
        }
    }
}

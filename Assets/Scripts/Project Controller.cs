using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectController : MonoBehaviour
{
    public float speed;
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
        transform.position += (Vector3)directionalInput * speed * Time.deltaTime;
        transform.up = worldMousePosition - transform.position;
    }

    public void OnMove (InputAction.CallbackContext context)
    {
        directionalInput = context.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Attack Time( " + context.phase + " )!");
        }
        
    }
}

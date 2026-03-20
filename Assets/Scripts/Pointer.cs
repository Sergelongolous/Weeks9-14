using UnityEngine;
using UnityEngine.InputSystem;

public class Pointer : MonoBehaviour
{

    private Vector3 worldMousePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        Vector2 currentMousePosition = context.action.ReadValue<Vector2>();
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
        //sworldMousePosition.z = 0;

        //Setting the direction we're looking in
        //To get the direction we do END - START
        transform.up = worldMousePosition - transform.position;

        //transform.position += transform.up * 1f * Time.deltaTime;
    }
}

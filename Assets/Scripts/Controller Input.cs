using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed;
    public Vector2 directionalInput;
    public Vector2 rotation;

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

    public void OnMove(InputAction.CallbackContext context)
    {
        directionalInput = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Attack Time( " + context.phase + " )!");
        }
       
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        Vector2 mousePosition = context.ReadValue<Vector2>();
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log("On Point:" + context.ReadValue<Vector2>());
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        //rotation = context.ReadValue<Vector2>();
      
    }
}

using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunLooker : MonoBehaviour
{
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
}

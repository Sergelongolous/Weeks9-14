using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PressE : MonoBehaviour
{
    public SpriteRenderer pressE;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSprite(InputAction.CallbackContext context)
    {
        pressE.gameObject.SetActive(true);
        if (Keyboard.current.eKey.ReadValue()==0)
        {
            SpriteRenderer.Destroy(pressE.gameObject);
        }
    }

}

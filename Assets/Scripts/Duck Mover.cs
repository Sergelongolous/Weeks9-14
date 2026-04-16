using UnityEngine;

public class DuckMover : MonoBehaviour
{
    public float speed = 0.02f;
    public float xMax;
    public float xMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed * Time.deltaTime;

        transform.position = moverXPos;

    }
}

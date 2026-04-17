using UnityEngine;

public class BulletMover : MonoBehaviour
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
        //Makes it so that each spawed prefab clone starts move towards the duck, facing the direction of the gun as well

        transform.position += transform.right * Time.deltaTime * speed;
    }
}

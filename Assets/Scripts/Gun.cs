using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float maxSpawnDistance;

    public float duration;
    public GameObject bulletPrefab;


    private Coroutine singleGunCoroutine;
    private Coroutine tripleGunCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private IEnumerator OneGunUpdate()
    {
        //setting a progress time
        float progress = 0f;

        //The contents of the while loop run while the condition is true
        while (progress < duration)
        {
            progress += Time.deltaTime;

            //GameObject spawnedObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //bulletPrefab.GetComponent<SpriteRenderer>().color = Color.red;
            


            Debug.Log("How long has it been since the last frame?: " + Time.deltaTime);
            yield return null;

        }

        //spawnes the object in on its set position of the gun, while also making it spawn wherever the gun is facing
        GameObject spawnedObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        spawnedObject.transform.right = transform.right;

        //destroys each spawned object clone after 2 seconds
        Destroy(spawnedObject, 2);

    }

    private IEnumerator ThreeGunUpdate()
    {

        //same code from the last coroutine but this time set in a for loop so that every click of the button makes the code happen 3 times
        for (int i=0; i < 3; i++)
        {
            float progress = 0f;

            //The contents of the while loop run while the condition is true
            while (progress < duration)
            {
                progress += Time.deltaTime;

                //GameObject spawnedObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                //bulletPrefab.GetComponent<SpriteRenderer>().color = Color.red;



                Debug.Log("How long has it been since the last frame?: " + Time.deltaTime);
                yield return null;

            }

            GameObject spawnedObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            spawnedObject.transform.right = transform.right;

            Destroy(spawnedObject, 2);
        }
       


    }

    public void OnShoot()
    {
        //calls the coroutine whenevr the A button is pressed
        singleGunCoroutine = StartCoroutine(OneGunUpdate());
    }

    public void OnTripleShoot()
    {
        //calls the coroutine whenever the B button is pressed
        tripleGunCoroutine = StartCoroutine(ThreeGunUpdate());
    }
}

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

    private IEnumerator TreeGrowUpdate()
    {
        float progress = 0f;

        //The contents of the while loop run while the condition is true
        while (progress < duration)
        {
            progress += Time.deltaTime;
            



            Debug.Log("How long has it been since the last frame?: " + Time.deltaTime);
            yield return null;
        }


    }
}

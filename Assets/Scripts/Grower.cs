using System.Collections;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public AnimationCurve growCurve;

    public float duration;
    public GameObject prefab;

    private Coroutine treeGrowCoroutine;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator GrowUpdate()
    {
        float progress = 0f;

        //The contents of the while loop run while the condition is true
        while (progress < duration)
        {
            progress += Time.deltaTime;
            transform.localScale = growCurve.Evaluate(progress / duration) * Vector3.one;

            //Relinquishes control of Unity so that everything else can run
            //For the rest of this frame
            Debug.Log("How long has it been since the last frame?: " + Time.deltaTime);
            yield return null;
        }

        treeGrowCoroutine = StartCoroutine(GrowUpdate());

    }
}

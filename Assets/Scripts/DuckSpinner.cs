using System.Collections;
using UnityEngine;

public class DuckSpinner : MonoBehaviour
{
    public AnimationCurve duckSpinner;
    public float duration;
    public float rotationSpeed;


    private Coroutine duckCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DuckSpinUpdate()
    {
        float progress = 0f;

        while (progress < duration)
        {
            progress += Time.deltaTime;
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z += rotationSpeed * Time.deltaTime;
            transform.eulerAngles = currentRotation;
            //transform.eulerAngles = duckSpinner.Evaluate(progress / duration) * Vector3.one;
            yield return null;
        }
    }

    public void OnSpin()
    {
        duckCoroutine = StartCoroutine(DuckSpinUpdate());
    }
}

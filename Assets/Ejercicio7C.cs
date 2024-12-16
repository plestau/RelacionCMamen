using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ejercicio7C : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<Vector3> points;
    public float speed = 1.0f;

    private GameObject cubeInstance;
    private int currentPointIndex = 0;

    void Start()
    {
        if (points.Count > 0)
        {
            cubeInstance = Instantiate(cubePrefab, points[0], Quaternion.identity);
            StartCoroutine(MoveCube());
        }
    }

    IEnumerator MoveCube()
    {
        while (true)
        {
            Vector3 startPoint = points[currentPointIndex];
            Vector3 endPoint = points[(currentPointIndex + 1) % points.Count];
            float journeyLength = Vector3.Distance(startPoint, endPoint);
            float startTime = Time.time;

            while (Vector3.Distance(cubeInstance.transform.position, endPoint) > 0.01f)
            {
                float distCovered = (Time.time - startTime) * speed;
                float fractionOfJourney = distCovered / journeyLength;
                cubeInstance.transform.position = Vector3.Lerp(startPoint, endPoint, fractionOfJourney);
                yield return null;
            }

            currentPointIndex = (currentPointIndex + 1) % points.Count;
        }
    }
}
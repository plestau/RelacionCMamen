using UnityEngine;

public class Ejercicio3C : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject cube = Instantiate(cubePrefab, new Vector3(0, i * 2.0f, 0), Quaternion.identity);
        }
    }
}
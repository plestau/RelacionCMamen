using UnityEngine;

public class Ejercicio2C : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(i * 2.0f, 0, 0);
        }
    }
}
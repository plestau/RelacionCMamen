using UnityEngine;

public class Ejercicio4C : MonoBehaviour
{
    public GameObject cubePrefab;
    public int size = 3; // Tamaño del cubo grande

    void Start()
    {
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    Vector3 position = new Vector3(x, y, z);
                    Instantiate(cubePrefab, position, Quaternion.identity);
                }
            }
        }
    }
}
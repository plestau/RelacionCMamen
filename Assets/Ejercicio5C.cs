using UnityEngine;

public class Ejercicio5C : MonoBehaviour
{
    public GameObject stonePrefab;
    public GameObject dirtPrefab;
    public GameObject grassPrefab;
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
                    GameObject prefabToUse;

                    if (y == size - 1)
                    {
                        prefabToUse = grassPrefab; // Capa superior de césped
                    }
                    else if (y >= size / 2)
                    {
                        prefabToUse = dirtPrefab; // Capa intermedia de tierra
                    }
                    else
                    {
                        prefabToUse = stonePrefab; // Capa inferior de piedra
                    }

                    Instantiate(prefabToUse, position, Quaternion.identity);
                }
            }
        }
    }
}
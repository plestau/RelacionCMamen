using UnityEngine;

public class Ejercicio6C : MonoBehaviour
{
    public GameObject cubePrefab;
    public int baseSize = 5; // Tamaño de la base de la pirámide

    void Start()
    {
        for (int y = 0; y < baseSize; y++)
        {
            for (int x = 0; x < baseSize - y; x++)
            {
                for (int z = 0; z < baseSize - y; z++)
                {
                    Vector3 position = new Vector3(x - (baseSize - y) / 2.0f, y, z - (baseSize - y) / 2.0f);
                    Instantiate(cubePrefab, position, Quaternion.identity);
                }
            }
        }
    }
}
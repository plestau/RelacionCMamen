using UnityEngine;

public class Ejercicio1C : MonoBehaviour
{
    void Start()
    {
        int sum = 0;
        for (int i = 0; i < 1000; i += 2)
        {
            sum += i;
        }
        Debug.Log("La suma de los primeros quinientos números pares es: " + sum);
    }
}
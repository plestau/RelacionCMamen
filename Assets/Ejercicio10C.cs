using UnityEngine;

public class Ejercicio10C : MonoBehaviour
{
    public GameObject cubePrefab;
    private GameObject[] cubes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubes = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f)
            );
            cubes[i] = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.transform.position.x > 0)
                {
                    Destroy(cube);
                }
            }
        }
    }
}
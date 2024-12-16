using UnityEngine;

public class Ejercicio9C : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] objectsToDisappear = GameObject.FindGameObjectsWithTag("Desaparecer");
            foreach (GameObject obj in objectsToDisappear)
            {
                obj.SetActive(false);
            }
        }
    }
}
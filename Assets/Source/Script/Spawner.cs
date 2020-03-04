using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] fruits;


    public float xbound, ybound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }
    
    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(0,5f));
        int randomFruits = Random.Range(0, fruits.Length);
        
        if (Random.value < 1f)
        {
            GameObject obj = Instantiate(fruits[randomFruits], new Vector2(Random.Range(-xbound, xbound), ybound), Quaternion.identity);
            obj.name = fruits[randomFruits].name;
        }
        StartCoroutine(SpawnRandomGameObject());
    }
}

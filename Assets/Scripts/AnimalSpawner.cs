using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject cowPrefab, deerPrefab, dogPrefab, horsePrefab;
    private GameObject animalPrefabs;
    void Start()
    {
        StartCoroutine(SpawnAnimal());
    }

    private IEnumerator SpawnAnimal()
    {
        do
        {
        yield return new WaitForSeconds(2f);

        int i = Random.Range(0,4);
        if(i == 0)
        {
            animalPrefabs = cowPrefab;
        }
        else if(i==1)
        {
            animalPrefabs = deerPrefab;
        }
        else if(i==2)
        {
            animalPrefabs = dogPrefab;
        }
        else if(i==3)
        {
            animalPrefabs = horsePrefab;
        }

        Vector3 randomPosition = new Vector3(Random.Range(20, -20), 0, 15); 
        Instantiate(animalPrefabs, randomPosition, transform.rotation);
        }
        while(true);
    }
}

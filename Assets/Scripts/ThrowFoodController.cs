using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFoodController : MonoBehaviour
{
    [SerializeField] public GameObject foodPrefab;
    [SerializeField] public Transform spawnPoint;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foodPrefab.transform.Translate(Vector3.up * 5);
            Instantiate(foodPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodThrow : MonoBehaviour
{
    public float force = 10;
    void Start()
    {
        transform.Translate(Vector3.up * 3);
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
        
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Animals")
        {
            AnimalHandler animalHandler = other.gameObject.GetComponent<AnimalHandler>();
            animalHandler.hungerNeed += 25;
        }
    }
}

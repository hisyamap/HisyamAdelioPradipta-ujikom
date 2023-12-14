using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimalHandler : MonoBehaviour
{
    public float animalSpeed;
    public float hungerNeed;
    public float animalHunger;
    public float animalScore;
    public GameUIManager gameUIManager;
    float addScore;
    void Update()
    {
        transform.Translate(Vector3.forward * animalSpeed * Time.deltaTime);
        if(hungerNeed >= animalHunger)
        {
            Destroy(gameObject);

            addScore += animalScore;  
            gameUIManager = gameObject.GetComponent<GameUIManager>();
            gameUIManager.updateScore(addScore);
        }
        Destroy(gameObject, 8.5f);
    }
}

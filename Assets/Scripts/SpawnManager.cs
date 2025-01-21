using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; //This is an array that contains GameObjects. This is done to save space. An array costs less then multiple items.
    

    //Range where they spawn in
    private float spawnRange = 20; //dont need two spawn ranges since their both the same value

    private float startDelay = 2f; //start of the delay.
    private float spawnInterval = 1.5f; //the interval when they spawn in;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange),
            0, spawnRange);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
    }
}

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnPosZ = 20;
    public float spawnPosX = 20f;
    public float spawnDelay = 2f;
    public float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

// void Update()
// {
// if (Input.GetKeyDown(KeyCode.S))
// {
// SpawnRandomAnimal();
// }
// }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnPosX,spawnPosX),
            0,
            spawnPosZ);

        Instantiate(animalPrefabs[animalIndex],
            spawnPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
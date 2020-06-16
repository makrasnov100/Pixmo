using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();

    //Settings
    public float scaleMin;
    public float scaleMax;
    public Vector3 topRightSpawnMax;
    public Vector3 bottomLeftSpawnMax;
    public float spawnRate;
    public float spawnHeight;

    // Update is called once per frame
    void Update()
    {
        SpawnNewObjects();
    }

    void SpawnNewObjects()
    {
        //TODO: handle ;out of range

        float randomChance = Random.Range(0f, 1f);

        if (randomChance < spawnRate)
        {
            GameObject curGameObject = Instantiate(enemies[0], this.transform);

            //Set random Pos
            float randomX = Random.Range(bottomLeftSpawnMax.x, topRightSpawnMax.x);
            float randomZ = Random.Range(bottomLeftSpawnMax.z, topRightSpawnMax.z);
            Vector3 spawnPos = new Vector3(randomX, spawnHeight, randomZ);
            curGameObject.transform.position = spawnPos;

            //Set random Scale
            float randomScale = Random.Range(scaleMin, scaleMax);
            curGameObject.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
        }
    }
}

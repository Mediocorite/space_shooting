using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesSpawn : MonoBehaviour
{
    // Varibles for spawn time and our prefab
    public GameObject EnemiesPrefab;
    public float spawnWidth;
    public float spawnHeight;
    public float resqawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // Starts the coroutine to call the enemies
        StartCoroutine(enemiesWave());
    }

    // Function for spawing enemies
    private void spawnEnemies()
    {
        GameObject enemy = Instantiate(EnemiesPrefab) as GameObject;
        enemy.transform.position = new Vector3(-spawnWidth, Random.Range(-spawnHeight, spawnHeight), 0);
    }
    // Function for the generating our spawpoints
    IEnumerator enemiesWave ()
    {
        while (true)
        {
            // Waits 1 second before executing again
            yield return new WaitForSeconds(resqawnTime);
            spawnEnemies();
        }
    }
}

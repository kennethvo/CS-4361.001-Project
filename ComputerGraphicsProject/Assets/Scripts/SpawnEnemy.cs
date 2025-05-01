using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime;
    public Vector3 spawnPosition;

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

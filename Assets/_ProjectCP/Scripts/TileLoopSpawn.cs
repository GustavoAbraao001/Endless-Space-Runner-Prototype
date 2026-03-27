using UnityEngine;

public class TileLoopSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] tilePrefabs;
    [SerializeField] private float tileSize = 30f;

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            hasSpawned = true;

            int randomIndex = Random.Range(0, tilePrefabs.Length);

            Vector3 spawnPosition = transform.position + new Vector3(0, 0, tileSize);

            Instantiate(tilePrefabs[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}

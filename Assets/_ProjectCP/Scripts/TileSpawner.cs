using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject tilePrefab;
    [SerializeField] private float tileSize = 30f;

    private bool hasSpawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasSpawned)
        {
            hasSpawned = true;

            Vector3 spawnPosition = transform.position + new Vector3(0, 0, tileSize);

            Instantiate(tilePrefab, spawnPosition, Quaternion.identity);
        }
    }
}

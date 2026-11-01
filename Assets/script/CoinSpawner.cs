
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnCoin),
            1f,
            spawnInterval
        );
    }

    void SpawnCoin()
    {
        float randomX = Random.Range(-7f, 7f);

        Vector3 spawnPosition = new Vector3(
            randomX,
            5f,
            0f
        );

        Instantiate(
            coinPrefab,
            spawnPosition,
            Quaternion.identity
        );
    }
}

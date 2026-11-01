
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject bombPrefab;

    public float spawnInterval = 1.5f;

    [Range(0f, 1f)]
    public float coinChance = 0.7f;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;

        InvokeRepeating(
            nameof(SpawnItem),
            1f,
            spawnInterval
        );
    }

    void SpawnItem()
    {
        float halfWidth =
            cam.orthographicSize * cam.aspect;

        float randomX = Random.Range(
            -halfWidth + 0.5f,
            halfWidth - 0.5f
        );

        float spawnY =
            cam.transform.position.y + cam.orthographicSize + 0.5f;

        Vector3 spawnPosition = new Vector3(
            randomX,
            spawnY,
            0f
        );

        GameObject selectedPrefab =
            Random.value < coinChance ? coinPrefab : bombPrefab;

        if (selectedPrefab != null)
        {
            Instantiate(
                selectedPrefab,
                spawnPosition,
                Quaternion.identity
            );
        }
    }
}

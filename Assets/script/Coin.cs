
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 4f;

    void Update()
    {
        transform.Translate(
            Vector2.down * speed * Time.deltaTime
        );

        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(1);

            Destroy(gameObject);
        }
    }
}

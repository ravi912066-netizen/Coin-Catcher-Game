
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float speed = 5f;

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
            GameManager.Instance.LoseLife();

            Destroy(gameObject);
        }
    }
}

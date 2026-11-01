
using UnityEngine;

public class coin : MonoBehaviour
{
    public float speed = 4f;

    void Start()
    {
        
    }

    void Update()
    {
        // Move coin downward
        transform.Translate(
            Vector2.down * speed * Time.deltaTime
        );

        // Destroy coin when it goes below screen
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}


using UnityEngine;

public class catcher : MonoBehaviour
{
    public float speed = 8f;

    float minX;
    float maxX;

    void Start()
    {
        Camera cam = Camera.main;

        float halfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

        float cameraHalfWidth = cam.orthographicSize * cam.aspect;

        minX = -cameraHalfWidth + halfWidth;
        maxX = cameraHalfWidth - halfWidth;
    }

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");

        transform.Translate(
            Vector2.right * input * speed * Time.deltaTime
        );

        float x = Mathf.Clamp(transform.position.x, minX, maxX);

        transform.position = new Vector3(
            x,
            transform.position.y,
            transform.position.z
        );
    }
}

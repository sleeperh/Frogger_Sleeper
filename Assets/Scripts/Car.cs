
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public int position;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    float speed = 1f;

    private void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed) * DataManager.speed;
    }
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y); // convert vector3 information to vector2
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed); // use forward var to make car go in the direction it is facing (forward)
    }

}

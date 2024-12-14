using UnityEngine;

public class RacketManager : MonoBehaviour
{
    float speed = 20f;
    Rigidbody2D rb;
    [SerializeField]
    string axisName;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float y = Input.GetAxisRaw(axisName) * speed;
        rb.linearVelocity = new Vector2(0, y);
    }
}

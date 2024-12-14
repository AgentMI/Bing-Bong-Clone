using UnityEngine;
using UnityEngine.UI;
public class BallManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text ScoreRight, ScoreLeft;
    Rigidbody2D rb;
    float speed = 20f;
    int scoreLeft = 0;
    int scoreRight = 0;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
                rb.linearVelocity = dir * speed;
        }
        if(collision.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            rb.linearVelocity = dir * speed;
        }
        if(collision.gameObject.name == "BorderLeft")
        {
            scoreRight++;
            ScoreRight.text = scoreRight.ToString();
        }
        if(collision.gameObject.name == "BorderRight")
        {
            scoreLeft++;
            ScoreLeft.text = scoreLeft.ToString();
        }
    }
}

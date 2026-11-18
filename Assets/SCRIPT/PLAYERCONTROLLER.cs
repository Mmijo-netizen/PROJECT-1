using UnityEngine;

public class PLAYERCONTROLLER : MonoBehaviour
{
    public float moveSpeed = 8f;    // брзина на одење
    public float jumpForce = 5f;    // јачина на скок
    public Sprite NormalSprite;     // слика кога стоиш
    public Sprite movingSprite;     // слика кога одиш

    Rigidbody2D rb;
    SpriteRenderer sprite;
    bool naZemja;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float levoDesno = Input.GetAxis("Horizontal");

        // одење
        rb.linearVelocity = new Vector2(levoDesno * moveSpeed, rb.linearVelocity.y);

        // скок (само ако стоиш на земја)
        if (Input.GetKeyDown(KeyCode.Space) && naZemja)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // слика и насока
        if (levoDesno > 0.01f)
        {
            sprite.flipX = false;            // гледа надесно
            sprite.sprite = movingSprite;
        }
        else if (levoDesno < -0.01f)
        {
            sprite.flipX = true;             // гледа налево
            sprite.sprite = movingSprite;
        }
        else
        {
            sprite.sprite = NormalSprite;    // стои
        }
    }

    void OnCollisionEnter2D(Collision2D other) { naZemja = true; }
    void OnCollisionExit2D(Collision2D other) { naZemja = false; }
}
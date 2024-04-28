using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And : MonoBehaviour
{
    public float speed;
    public float speedNow;
    public float speedDecay;
    public Rigidbody2D rb;
    public int jumps;
    public float jumpPower;
    public float minFallSpeed;
    float gravityNorm;
    public float dashPower;
    public int whatDirection;
    public bool isDashing;
    public float DashTime;
    float dashTimeNow;
    public int NumberOfDashes;

    public int maxHealth;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        gravityNorm = rb.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDashing)
        {
            speedNow += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
            rb.velocity = new Vector2(speedNow, rb.velocity.y);

            if (Input.GetKeyDown("space") && jumps > 0) { if (rb.velocity.y < jumpPower) { rb.velocity = new Vector2(rb.velocity.x, jumpPower); jumps--; } }

            rb.gravityScale = gravityNorm;
            if (Input.GetKey("space")) { if (rb.velocity.y <= minFallSpeed) { rb.velocity = new Vector2(rb.velocity.x, minFallSpeed); rb.gravityScale = 0; } }

            if (whatDirection * 1 == Input.GetAxisRaw("Horizontal")) { whatDirection *= -1; }

            transform.localScale = new Vector2(-1 * whatDirection, 1);
            if (Input.GetKeyDown(KeyCode.LeftShift) && NumberOfDashes > 0)
            {
                isDashing = true;
                dashTimeNow = DashTime;
                rb.gravityScale = 0;
                rb.velocity = new Vector2(dashPower * whatDirection * -1, 0);
                NumberOfDashes--;
            }
        }
        else { dashTimeNow -= Time.deltaTime; if (dashTimeNow < 0) { isDashing = false; }  }

        
    }

    void FixedUpdate()
    {
        speedNow *= speedDecay;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        jumps = 2;
        NumberOfDashes = 1;
    }
}

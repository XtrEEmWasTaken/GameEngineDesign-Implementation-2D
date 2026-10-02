using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tr;
    bool jumpInput;
    bool isGrounded;
    float horizontalInput;
    float moveSpeed = 8f;
    float jumpForce = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocityY);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
                for (int i = 0; i < collision.contacts.Length; i++)
        {
            if (collision.contacts[i].normal.y > 0.5)
            {
                isGrounded = true;
            }   
        }
        
        if (collision.gameObject.CompareTag("Spike"))
        {
            respawn();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Manager.Instance.AddCoin();
            Destroy(collision.gameObject);
        }
    }
     void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    void respawn()
    {
        tr.position = new Vector3(0, -3, 0);
    }

}

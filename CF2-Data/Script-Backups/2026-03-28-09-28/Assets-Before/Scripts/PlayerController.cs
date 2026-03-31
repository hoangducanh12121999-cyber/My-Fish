using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    bool isSwimUp = true;
    [SerializeField] private float swimSpeed = 5f;
    bool isDead = false;
    bool isInRange = false;
    [SerializeField] float angleUp = 20f;

    public AudioClip scoreClip;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSwimUp = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Dir();
        if (isInRange && Input.GetKeyDown(KeyCode.Space))
        {
            isInRange = false;
        }
        if (isDead)  
            swimSpeed = 0f;
    }

    private void FixedUpdate()
    {
        HandleMove();
    }

    private bool Dir() 
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isSwimUp = !isSwimUp;
        }
        return isSwimUp;
    }

    public void HandleMove()
    {
        if (isInRange) return;

        if (isSwimUp)
        {
            rb.MovePosition(rb.position + Vector2.up * swimSpeed * Time.fixedDeltaTime);
            rb.transform.rotation = Quaternion.Euler(0, 0, angleUp);
        }
        if (!isSwimUp)
        {
            rb.MovePosition(rb.position + Vector2.down * swimSpeed * Time.fixedDeltaTime);
            rb.transform.rotation = Quaternion.Euler(0, 0, -angleUp);
        }
    }

    public void Dead()
    {
        if (isDead) return;
        isDead = true;
        anim.SetTrigger("isDead");
        Time.timeScale = 0;
        AudioManager.Instance.GameOver(scoreClip);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Range"))
        {
            isInRange = true;
        }
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Dead();
        }
    }


    



}

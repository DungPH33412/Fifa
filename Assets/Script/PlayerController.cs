using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public GameObject kickButton;
    public Transform ball;
    public float kickDistance = 2f;
    Animator anim;

    Vector3 movement;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A D
        float v = Input.GetAxis("Vertical");   // W S

        movement = new Vector3(h, 0, v);

        float speed = movement.magnitude;
        anim.SetFloat("Speed", speed);
        anim.SetFloat("Speed", movement.magnitude, 0.1f, Time.deltaTime);

        if (movement != Vector3.zero)
        {
            transform.forward = movement; // nhìn theo hướng di chuyển
        }
        // kiểm tra khoảng cách
        float dist = Vector3.Distance(transform.position, ball.position);

        if (dist < kickDistance)
            kickButton.SetActive(true);
        else
            kickButton.SetActive(false);
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}

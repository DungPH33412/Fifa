using UnityEngine;

public class BallController : MonoBehaviour
{
   public Rigidbody rb;
    public bool isMoving = false;

    public void Kick(Vector3 direction, float force)
    {
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(direction.normalized * force, ForceMode.Impulse);
        isMoving = true;
    }
}

using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public ParticleSystem effect;
    public CameraFollow cam;
    public BallController ball;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            effect.Play();
            ball.isMoving = false;

            Invoke("ReturnCamera", 2f);
        }
    }

    void ReturnCamera()
    {
        cam.ball.isMoving = false;
    }
}

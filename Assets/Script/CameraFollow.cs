using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public BallController ball;
    public Transform player;

    void LateUpdate()
    {
        if (ball.isMoving)
            transform.position = ball.transform.position + offset;
        else
            transform.position = player.position + offset;
    }
}

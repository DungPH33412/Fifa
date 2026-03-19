using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallController ball;
    public Transform[] goals; // nhiều khung thành

    //  tìm khung thành gần nhất
    Transform GetNearestGoal()
    {
        Transform nearest = null;
        float minDist = Mathf.Infinity;

        foreach (Transform g in goals)
        {
            float dist = Vector3.Distance(ball.transform.position, g.position);

            if (dist < minDist)
            {
                minDist = dist;
                nearest = g;
            }
        }

        return nearest;
    }
    public void KickBall()
    {
        Transform goal = GetNearestGoal();

        Vector3 dir = goal.position - ball.transform.position;

        ball.Kick(dir, 10f); // lực nhẹ hơn auto
    }
    public void AutoKick()
    {
        Transform goal = GetNearestGoal();

        Vector3 dir = goal.position - ball.transform.position;

        ball.Kick(dir, 15f);
    }
}
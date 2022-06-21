using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScr : MonoBehaviour
{
    public GameObject leftPlayer;
    public GameObject rightPlayer;
    private float PongBallHSpeed;
    private float PongBallVSpeed;
    int scoreLeft = 0;
    int scoreRight = 0;
    bool pongBallNeedsReset = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        int choice = Random.Range(0, 2);
        PongBallVSpeed = choice == 0 ? -0.01f : 0.01f;
        choice = Random.Range(0, 2);
        PongBallHSpeed = choice == 0 ? -0.01f : 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12.5)
        {
            scoreRight++;
            pongBallNeedsReset = true;
        }

        if (transform.position.x > 12.5)
        {
            scoreLeft++;
            pongBallNeedsReset = true;
        }

        if (pongBallNeedsReset)
        {
            pongBallNeedsReset = false;
            Debug.Log("Player 1: " + scoreLeft + " | Player 2: " + scoreRight);
            transform.position = new Vector3(0, 0, 0);
            int choice = Random.Range(0, 2);
            PongBallVSpeed = choice == 0 ? -0.01f : 0.01f;
            choice = Random.Range(0, 2);
            PongBallHSpeed = choice == 0 ? -0.01f : 0.01f;
        }


        if (transform.position.y + PongBallVSpeed > 4.3)
        {
            PongBallVSpeed = -PongBallVSpeed;
        }

        if (transform.position.y + PongBallVSpeed < -4.3)
        {
            PongBallVSpeed = -PongBallVSpeed;
        }

        if (transform.position.x + PongBallHSpeed < -10
            && transform.position.x + PongBallHSpeed > -10.1)
        {
            if (Mathf.Abs(leftPlayer.transform.position.y - transform.position.y) < 1.5)
            {
                PongBallHSpeed = -PongBallHSpeed;
            }
        }

        if (transform.position.x + PongBallHSpeed > 10
            && transform.position.x + PongBallHSpeed < 10.1)
        {
            if (Mathf.Abs(rightPlayer.transform.position.y - transform.position.y) < 1.5)
            {
                PongBallHSpeed = -PongBallHSpeed;
            }
        }

        transform.Translate(PongBallHSpeed, PongBallVSpeed, 0f);
    }
}

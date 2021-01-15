using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{

    public Rigidbody rigidbody;
    public AudioSource pinStrike;
    public AudioSource ballWallStrike;
    public SphereCollider bowlingBall;
    public GameObject gameObject;

    public int strikeCount;
    public Transform bowlingBallTransform;

    private Vector3 movePos;
    private Quaternion startAngle;

    private bool forward;
    public bool isStartPositionSet;
    private bool isForceSet;

    // when bowling ball collider enters pin collider then play ball clash sound
    // when pins clash with pins then play pin on pin sound

    // Start is called before the first frame update
    void Start()
    {
        // rigidbody.AddForce(0,0,80000);
        strikeCount = 0;

        movePos.x = bowlingBallTransform.position.x;
        movePos.y = bowlingBallTransform.position.y;
        movePos.z = bowlingBallTransform.position.z;

        startAngle = bowlingBallTransform.rotation;

        forward = true;
        isStartPositionSet = false;
        isForceSet = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        RandomiseBallPosition();

    }

    private void Update()
    {

        CheckKeyInput();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Pin>())
        {
            {

                pinStrike.Play();
                strikeCount = strikeCount+1;
                // Debug.Log(strikeCount);

            }
        }

        if (collision.gameObject.GetComponent<RearWall>())
        {

            ballWallStrike.Play();

        }
    }

    private void CheckKeyInput()
    {

        if (Input.GetKeyDown("space"))
        {

            rigidbody.AddForce(0, 0, 80000);

        }

        if (Input.GetKeyDown("up"))
        {

            rigidbody.AddForce(0, 0, 10000);

        }

        if (Input.GetKeyDown("left"))
        {

            rigidbody.AddForce(-10000, 0, 0);

        }

        if (Input.GetKeyDown("right"))
        {

            rigidbody.AddForce(10000, 0, 0);

        }

        if (Input.GetKeyDown("down"))
        {

            rigidbody.AddForce(0, 0, -10000);

        }

        if (Input.GetKeyDown("b"))
        {

            isStartPositionSet = true;
            //bowlingBallTransform.SetPositionAndRotation(movePos, startAngle);

        }

    }

    private void RandomiseBallPosition()
    {

           // was testing for keydown"b" here, but physics fixed time update caused input lag/fail to register
           // moved to per frame update method instead

        if (forward && !isStartPositionSet)
            {

                //forward = false;

                movePos.x = bowlingBallTransform.position.x + 0.8f;

                bowlingBallTransform.SetPositionAndRotation(movePos, startAngle);

                if (bowlingBallTransform.position.x >= 10)
                {

                    forward = false;

                }

            }
            else if (!forward && !isStartPositionSet)
            {

                //forward = true;

                movePos.x = bowlingBallTransform.position.x - 0.8f;

                bowlingBallTransform.SetPositionAndRotation(movePos, startAngle);

                if (bowlingBallTransform.position.x <= -3)
                {

                    forward = true;

                }

            }
    }
}

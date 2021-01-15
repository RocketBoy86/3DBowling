using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class BallStartPosController : MonoBehaviour
{

    public Transform ballStartPosTransform;
    public Rigidbody ballStartPosRigidbody;

    private Vector3 movePos;
    private Quaternion startAngle;

    // Start is called before the first frame update
    void Start()
    {

        movePos.y = ballStartPosTransform.position.y;
        movePos.z = ballStartPosTransform.position.z;

        startAngle = ballStartPosTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // want transform to move from -3 to +10 across the X axis until user presses B key

        if (ballStartPosTransform.position.x >= 10)
        {
            
            movePos.x = ballStartPosTransform.position.x - 0.01f;

            ballStartPosTransform.SetPositionAndRotation(movePos, startAngle);

        } else if (ballStartPosTransform.position.x <= -3)
        {

            movePos.x = ballStartPosTransform.position.x + 0.01f;

            ballStartPosTransform.SetPositionAndRotation(movePos, startAngle);

        }
    }

}

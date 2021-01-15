using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BallCamera : MonoBehaviour
{

    public BowlingBall bowlingBall;
    public Transform bowlingBallCamera;

    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        //cameraOffset = bowlingBallCamera.position - bowlingBall.bowlingBallTransform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (bowlingBall.isStartPositionSet == true)
        {

            // bowlingBallCamera.position = bowlingBall.bowlingBallTransform.position + cameraOffset;

            cameraOffset.x = bowlingBallCamera.position.x;
            cameraOffset.y = bowlingBallCamera.position.y;
            cameraOffset.z = bowlingBall.bowlingBallTransform.position.z - 17.4f;

            bowlingBallCamera.position = cameraOffset;

            //bowlingBallCamera.SetPositionAndRotation(cameraOffset, startAngle);

        } 
    }
}

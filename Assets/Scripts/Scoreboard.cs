using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{

    public TMP_Text scoreboard;
    public BowlingBall bowlingBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreboard.text = "Pins hit: " + bowlingBall.strikeCount;

    }
}

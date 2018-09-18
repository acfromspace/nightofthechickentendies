using UnityEngine;
using System.Collections;

public class proto_MovingPlatform : MonoBehaviour {

    public Transform movingPlatform;
    public Transform startPosition;
    public Transform endPosition;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;

    private void Start()
    {
        ChangeTarget();
    }

    private void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
    }

    void ChangeTarget()
    {
        if (currentState == "Going to start")
        {
            currentState = "Going to end";
            newPosition = endPosition.position;
        }
        else if (currentState == "Going to end")
        {
            currentState = "Going to start";
            newPosition = startPosition.position;
        }
        else if (currentState == "")
        {
            currentState = "Going to end";
            newPosition = endPosition.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}

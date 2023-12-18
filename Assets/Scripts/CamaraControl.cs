using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamaraControl : MonoBehaviour
{
    public GameObject objective;
    public float minXposition;
    public float maxXposition;
    public float minYposition;
    public float maxYposition;
    public float cameraSpeed;

    private Vector3 refVelocity;

    void Update()
    {
        float xPosition = Mathf.Clamp(objective.transform.position.x, minXposition, maxXposition);
        float yPosition = Mathf.Clamp(objective.transform.position.y, minYposition, maxYposition);
        Vector3 objetivePosition = new Vector3(xPosition, yPosition, -10);

        if (transform.position != objetivePosition)
        {
            transform.position = Vector3.SmoothDamp(transform.position, objetivePosition, ref refVelocity, cameraSpeed);
        }
    }
}


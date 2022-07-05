using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsCam : MonoBehaviour
{
    public Transform[] PosCams;
    public Transform Cam;
    public Vector3 offset;
    public float smoothSpeed = 0.130f;

    private Vector3 desiredPosition;

    public int i = 0;

    private void Start()
    {
        TrocarCamera();
    }

    void FixedUpdate()
    {
        var smoothedPosition = Vector3.Lerp(Cam.position, desiredPosition, smoothSpeed);
        Cam.position = smoothedPosition;
    }

    public void TrocarCamera()
    {
        desiredPosition = PosCams[i].position + offset;
        i++;

        if (i > (PosCams.Length - 1))
        {
            i = 0;
        }
    }
}

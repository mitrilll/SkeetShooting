using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 _cameraFollowPosition;

    public void Setup(Vector3 cameraFollowPosition)
    {
        this._cameraFollowPosition = cameraFollowPosition;
    }

    private void Update()
    {
        Vector3 cameraFollowPosition = new Vector3(0, 100);
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}

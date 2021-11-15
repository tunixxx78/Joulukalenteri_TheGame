using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform followTarget;
    public float followSpeed = 5;
    Vector3 offset;

    private void Start()
    {
        offset = followTarget.position - transform.position;

    }

    private void LateUpdate()
    {
        if(followTarget)
        {
            transform.position = followTarget.position - offset;
        }
    }
}

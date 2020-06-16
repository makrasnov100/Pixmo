using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FollowCamIsometricx : MonoBehaviour
{
    public GameObject playerRef;

    //Settings
    public Vector3 offset;
    public float smoothParam;


    //Instance Variables
    Vector3 targetPos;

    void Start()
    {
        transform.position = playerRef.transform.position + offset;
        targetPos = transform.position;
        transform.LookAt(playerRef.transform.position);
    }

    // Update is called once per frame
    void Update()
    {   
        if(playerRef)
            NavigateToPlayer();
    }

    void NavigateToPlayer()
    {
        targetPos = playerRef.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothParam);
    }
}

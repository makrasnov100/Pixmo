using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePlayer(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MovePlayer(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MovePlayer(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MovePlayer(0, 1);
        }
    }

    void MovePlayer(float xDelta, float zDelta)
    {
        Vector3 curPos = transform.position;
        float newX = curPos.x + xDelta;
        float newZ = curPos.z + zDelta;

        transform.position = new Vector3(newX, curPos.y, newZ);
    }
}

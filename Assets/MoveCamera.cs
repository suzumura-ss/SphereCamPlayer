using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    // Use this for initialization
    private float _yaw = 0;
    private float _pitch = 0;
    void Start()
    {
    }

    // Update is called once per frame
    private static Vector3 _Yaxis = new Vector3(0, 1, 0);
    private static Vector3 _Xaxis = new Vector3(1, 0, 0);
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _yaw += 1.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _yaw -= 1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow) && _pitch > -90.0f)
        {
            _pitch -= 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow) && _pitch < 90.0f)
        {
            _pitch += 1.0f;
        }
        transform.LookAt(new Vector3(0, 0, 1));
        transform.Rotate(_Yaxis, _yaw);
        transform.Rotate(_Xaxis, _pitch);
    }
}

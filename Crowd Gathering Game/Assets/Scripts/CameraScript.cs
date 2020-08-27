using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform PlayerPos;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1f)]
    public float Smooth = 0.5f;
  
    void Start()
    {
     _cameraOffset = transform.position - PlayerPos.position;   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = PlayerPos.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos , Smooth);
    }
}

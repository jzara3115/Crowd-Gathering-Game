using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerPos;

    private Vector3 offset;

    [Range(0.01f, 1f)]
    public float Smooth = 0.5f;

    void Start()
    {
        offset = transform.position - PlayerPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = PlayerPos.position + offset;

        transform.position = Vector3.Slerp(transform.position, newPos , Smooth);
    }
}

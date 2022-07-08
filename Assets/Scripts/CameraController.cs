using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerPos;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - playerPos.position;
    }
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, playerPos.position + offset, 0.1f);
    }
}

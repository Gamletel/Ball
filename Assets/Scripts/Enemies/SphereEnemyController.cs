using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEnemyController : MonoBehaviour
{
    [SerializeField] Transform[] points;
    private int nextPoint;
    [SerializeField] private int speed = 2;
    [SerializeField] ParticleSystem moveParticle;
    void Start()
    {
        moveParticle.startSpeed = speed;
        transform.position = points[0].position;
    }
    void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[nextPoint].position, Time.deltaTime * speed);
        transform.LookAt(points[nextPoint]);
        if (Vector3.Distance(transform.position, points[nextPoint].position) < 0.5f)
                RandomizeNextPoint();
    }
    private void RandomizeNextPoint()
    {
        nextPoint = Random.Range(0, points.Length);
    }
}

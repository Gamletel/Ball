using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wildball.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2f;
        private Rigidbody rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }
        public void MoveCharacter(Vector3 movement)
        {
            rb.AddForce(movement * speed);
        }
    }
}
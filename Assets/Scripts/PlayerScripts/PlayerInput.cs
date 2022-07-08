using UnityEngine;

namespace wildball.Inputs
{
    [RequireComponent(typeof(PlayerMove))]
    public class PlayerInput : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMove playerMove;
        private void Start()
        {
            playerMove = GetComponent<PlayerMove>();
        }
        void Update()
        {
            float horizontal = Input.GetAxis(GlobalValues.Horizontal_Axis);
            float vertical = Input.GetAxis(GlobalValues.Vertical_Axis);
            movement = new Vector3(horizontal, 0, vertical).normalized;
        }
        private void FixedUpdate()
        {
            playerMove.MoveCharacter(movement);
        }
    }
}
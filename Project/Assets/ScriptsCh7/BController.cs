using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter.Command
{
    public class BController : MonoBehaviour
    {
        public enum Direction
        {
            Left = -1,
            Right = 1
        }
        private bool _isTurboOn;
        private float _distance = 1.0f;
        public void ToggleTurbo()
        {
            _isTurboOn = !_isTurboOn;
            Debug.Log("Turbo Active: " + _isTurboOn.ToString());
        }
        public void Turn(Direction direction)
        {
            if (direction == Direction.Left)
                transform.Translate(Vector3.left * _distance);
            if (direction == Direction.Right)
                transform.Translate(Vector3.right * _distance);
        }
        public void ResetPosition()
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}


using Chapter.Command;
using Chapter.EventBus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class InputHandler : MonoBehaviour
    {
        private Invoker _invoker;
        private bool _isReplaying;
        private bool _isRecording;
        private BController _bController;
        private Command _buttonA, _buttonD, _buttonW;
        void Start()
        {
            _invoker = gameObject.AddComponent<Invoker>();
            _bController = FindObjectOfType<BController>();
            _buttonA = new TurnLeft(_bController);
            _buttonD = new TurnRight(_bController);
            _buttonW = new ToggleTurbo(_bController);
        }
        void Update()
        {
            if (!_isReplaying && _isRecording)
            {
                if (Input.GetKeyUp(KeyCode.A))
                    _invoker.ExecuteCommand(_buttonA);
                if (Input.GetKeyUp(KeyCode.D))
                    _invoker.ExecuteCommand(_buttonD);
                if (Input.GetKeyUp(KeyCode.W))
                    _invoker.ExecuteCommand(_buttonW);
            }
        }
        void OnGUI()
        {
            if (GUILayout.Button("Start Recording"))
            {
                _bController.ResetPosition();
                _isReplaying = false;
                _isRecording = true;
                _invoker.Record();
            }
            if (GUILayout.Button("Stop Recording"))
            {
                _bController.ResetPosition();
                _isRecording = false;
            }
            if (!_isRecording)
            {
                if (GUILayout.Button("Start Replay"))
                {
                    _bController.ResetPosition();
                    _isRecording = false;
                    _isReplaying = true;
                    _invoker.Replay();
                }
            }
        }
    }
}


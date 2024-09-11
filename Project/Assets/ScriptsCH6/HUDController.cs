using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.EventBus
{
    public class HUDController : MonoBehaviour
    {
        private bool _isDisplayOn;
        void OnEnable()
        {
            RaceEventBus.Subscribe(
            RaceEventType.START, DisplayHUD);
        }
        void OnDisable()
        {
            RaceEventBus.Unsubscribe(
            RaceEventType.START, DisplayHUD);
        }
        private void DisplayHUD()
        {
            _isDisplayOn = true;
        }
        void OnGUI()
        {
            if (_isDisplayOn)
            {
                if (GUILayout.Button("Stop Race"))
                {
                    _isDisplayOn = false;
                    RaceEventBus.Publish(RaceEventType.STOP);
                }
            }
            if (GUILayout.Button("Next Scene"))
            {
                SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex + 1);
               
            }
        }
    }
}
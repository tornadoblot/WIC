using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PedometerU.Tests
{

    using UnityEngine;
    using UnityEngine.UI;

    public class StepCountManager : MonoBehaviour
    {

        public Text stepText;
        private Pedometer pedometer;

        private void Start()
        {
            // Create a new pedometer
            pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in feet
            stepText.text = steps.ToString();
        }

        private void OnDisable()
        {
            // Release the pedometer
            pedometer.Dispose();
            pedometer = null;
        }
    }
}
using UnityEngine;
using Random = UnityEngine.Random;


namespace _Developers.Felix
{
    public class SquareColor : MonoBehaviour
    {
        [SerializeField] private float length;
        [SerializeField] private float timeRemaining;
        private bool _timerIsRunning;

        private void Start()
        {
            // Starts the timer automatically
            _timerIsRunning = true;
            timeRemaining = length;
        }

        private void Update()
        {
            if (_timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    var sprite = this.GetComponent<SpriteRenderer>();
                    sprite.color = Random.ColorHSV();
                    timeRemaining = length;
                }
            }
        }
    }
}
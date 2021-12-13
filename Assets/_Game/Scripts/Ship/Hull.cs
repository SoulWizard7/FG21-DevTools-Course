using UnityEngine;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        [SerializeField] private IntVariable _health;
        [SerializeField] private IntReference _healthRef;
        [SerializeField] private ScriptableEvents _onhealthChangedEvent;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                _health.ApplyChange(-1);
                _onhealthChangedEvent.Raise();
            }
        }
    }
}

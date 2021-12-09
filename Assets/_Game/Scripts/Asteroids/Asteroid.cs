using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Asteroid : MonoBehaviour
    {
        public Guid Id { get; private set; }

        [Header("Values")]
        [SerializeField] private float _minForce;
        [SerializeField] private float _maxForce;
        [SerializeField] private float _minSize;
        [SerializeField] private float _maxSize;
        [SerializeField] private float _minTorque;
        [SerializeField] private float _maxTorque;
        [SerializeField] private float _maxLifetime;

        [Header("References")]
        [SerializeField] private Transform _shape;

        private Rigidbody2D _rigidbody;
        private float _lifetime;
        private Vector3 _direction;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            Id = Guid.NewGuid();

            SetDirection();
            AddForce();
            AddTorque();
            SetSize();
        }

        private void SetDirection()
        {
            var size = new Vector2(3f, 3f);
            var target = new Vector3
            (
                Random.Range(-size.x, size.x),
                Random.Range(-size.y, size.y)
            );

            _direction = (target - transform.position).normalized;
        }

        private void AddForce()
        {
            var force = Random.Range(_minForce, _maxForce);
            _rigidbody.AddForce( _direction * force, ForceMode2D.Impulse);
        }

        private void AddTorque()
        {
            var torque = Random.Range(_minTorque, _maxTorque);
            var roll = Random.Range(0, 2);

            if (roll == 0)
                torque = -torque;
            
            _rigidbody.AddTorque(torque, ForceMode2D.Impulse);
        }

        private void SetSize()
        {
            var size = Random.Range(_minSize, _maxSize);
            _shape.localScale = new Vector3(size, size, 0f);
        }

        public void OnShootAsteroid(Guid id)
        {
            if (id == Id)
                Destroy(gameObject);
        }

        private void FixedUpdate()
        {
            UpdateLifetime();
        }
        
        private void UpdateLifetime()
        {
            _lifetime += Time.fixedDeltaTime;

            if (_lifetime >= _maxLifetime)
                Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeEngine
{
    public class CubeMovement
    {        
        private Transform _transform;
        private Rigidbody _rb;
        public CubeMovement(Transform transform, Rigidbody rb)
        {
            _transform = transform;
            _rb = rb;
        }
        public void AddRelativeMove(float force,float yDir,float xDir)
        {
            _rb.AddForce(_rb.transform.up * yDir * force, ForceMode.Force);
            _rb.AddForce(_rb.transform.right * xDir * force, ForceMode.Force);
        }
        public void AddRelativeMove(float yDir, float xDir, int t)
        {
            _transform.position = new Vector3(
                _transform.position.x + xDir * (t * 0.1f),
                _transform.position.y + yDir * (t * 0.1f));
        }
    }
}
using CubeEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCube : MonoBehaviour, ICubeMovement
{
    #region Interface ICubeMovement
    public float xDir { get; private set; }

    public float yDir { get; private set; }

    public void SetDirection(float _xDir, float _yDir)
    {
        xDir = _xDir;
        yDir = _yDir;
    }
    #endregion
    public abstract Rigidbody m_rigidbody();
    public abstract CubeMovement cubeMovement();
}

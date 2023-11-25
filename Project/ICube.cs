using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICubeMovement
{
    float xDir { get; }
    float yDir { get; }
    void SetDirection(float _xDir, float _yDir);
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CubeEngine;

[RequireComponent(typeof(Rigidbody))]

public class MonoCube : BaseCube
{
    public float forceMove;
    public override CubeMovement cubeMovement()
    {
        return new CubeMovement(transform, m_rigidbody());
    }
    public override Rigidbody m_rigidbody()
    {
        return GetComponent<Rigidbody>();
    }
    public void DirectionTranslate()
    {
        SetDirection(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        cubeMovement().AddRelativeMove(forceMove,yDir,xDir);
    }
}

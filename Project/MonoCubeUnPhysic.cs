using CubeEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoCubeUnPhysic : BaseCube
{
    public int forceMove;
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
        cubeMovement().AddRelativeMove(yDir, xDir, forceMove);
    }
}

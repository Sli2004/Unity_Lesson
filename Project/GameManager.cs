using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MonoCube monoCube;
    public MonoCubeUnPhysic monoCubeUnPhysic;
    void Start()
    {
              
    }

    void Update()
    {       
        monoCube.DirectionTranslate();
        monoCubeUnPhysic.DirectionTranslate();
    }
}

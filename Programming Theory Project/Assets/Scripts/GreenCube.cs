using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE

public class GreenCube : ShapeBehaviour
{
    //POLIMORHISM
    public override void MoveClickedObject()
    {
        transform.position += new Vector3(0,0,(DistanseBetweenCubes.Instance.ZDistanceBetweenCubes()) * -1);
        
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : ShapeBehaviour
{

    public override void MoveClickedObject()
    {
        transform.position += new Vector3(0,0,(DistanseBetweenCubes.Instance.ZDistanceBetweenCubes()) * -1);
    }

}
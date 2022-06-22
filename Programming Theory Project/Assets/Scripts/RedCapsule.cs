using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCapsule : ShapeBehaviour
{

    public override void MoveClickedObject()
    {
        transform.position += new Vector3((DistanseBetweenCubes.Instance.ZDistanceBetweenCubes()) * -1,0,0);
    }

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}

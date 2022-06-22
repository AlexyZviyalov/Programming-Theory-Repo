using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanseBetweenCubes : MonoBehaviour
{
    //INCAPSULATION
    public static DistanseBetweenCubes Instance { get; private set; }

    public GameObject cubeA1;
    public GameObject cubeA2;
    public GameObject cubeB1;

    public float zDistance;
    public float xDistance;

    Vector3 zDifference;
    Vector3 xDifference;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    //ABSTRACTION
    public float ZDistanceBetweenCubes()
    {
        zDifference = cubeA1.transform.position - cubeB1.transform.position;
        zDistance = zDifference.z;
        return zDistance;
    }
    //ABSTRACTION
    public float XDistanceBetweenCubes()
    {
        xDifference = cubeA1.transform.position - cubeA2.transform.position;
        xDistance = xDifference.x;

        return xDistance;
    }
}

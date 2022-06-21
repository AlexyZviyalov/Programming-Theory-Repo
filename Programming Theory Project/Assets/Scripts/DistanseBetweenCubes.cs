using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanseBetweenCubes : MonoBehaviour
{
    public static DistanseBetweenCubes Instance;

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

    
    public float ZDistanceBetweenCubes()
    {
        zDifference = cubeA1.transform.position - cubeB1.transform.position;
        zDistance = zDifference.z;
        return zDistance;
    }

    public float XDistanceBetweenCubes()
    {
        xDifference = cubeA1.transform.position - cubeA2.transform.position;
        xDistance = xDifference.x;

        return xDistance;
    }
}
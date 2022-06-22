using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBehaviour : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        DetectTheClick();
        
    }

    void DetectTheClick()
    {
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.name == gameObject.name)
                {
                    MoveClickedObject();
                }

            }
        }
    }

    public virtual void MoveClickedObject()
    {
        transform.position += new Vector3(0, 0, DistanseBetweenCubes.Instance.ZDistanceBetweenCubes());
    }
}

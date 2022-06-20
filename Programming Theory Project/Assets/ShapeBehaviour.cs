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
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(hit.collider.name);
                Debug.Log("hit");
                transform.position += Vector3.forward * Time.deltaTime;
            }
        }

        
        
}
}

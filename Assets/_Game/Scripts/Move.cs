using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform bike; //decleration
    public Vector3 from, to;

    private void Start()
    {
        bike = gameObject.transform; //defining
        
    }

    private void Update()
    {
        if (bike.position.x > 1)
        {
            bike.Translate(-0.01f, 0, 0);
        }
        else
        {
            bike.position = new Vector3(8, bike.position.y, bike.position.z);
        }
    }
}

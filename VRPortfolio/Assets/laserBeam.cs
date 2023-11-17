using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBeam : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform rayOrigin;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit))
        {
            Debug.DrawRay(rayOrigin.position, rayOrigin.forward*hit.distance, Color.red);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

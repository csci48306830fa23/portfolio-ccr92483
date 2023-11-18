using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class bulletSpawner : MonoBehaviour
{

    [SerializeField]
    bullets bulletsPrefab;

    [SerializeField]
    Transform rayOrigin;

    [SerializeField]
    InputAction fireAction;

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit))
        {
            Debug.DrawRay(rayOrigin.position, rayOrigin.forward * hit.distance, Color.red);
            Debug.Log(rayOrigin.position);

            fireAction.performed += (obj) =>
            {

                // pewpew = gun noise 
                bullets pewpew = GameObject.Instantiate(bulletsPrefab, rayOrigin.position, rayOrigin.rotation);
                Rigidbody rb = pewpew.GetComponent<Rigidbody>();
                Debug.Log(hit.distance);

                if (hit.distance < 2)
                {
                    Debug.Log(hit.distance);
                }
                if (hit.distance < 2)
                {
                    rb.velocity = new Vector3(0f, 3f, 3f);

                }

                if (hit.distance > 2 && hit.distance < 4)
                {
                    rb.velocity = new Vector3(0f, 4f, 5f);
                }

                if (hit.distance > 4 && hit.distance < 6)
                {
                    rb.velocity = new Vector3(0f, 4f, 7f);
                }

                if (hit.distance > 6 && hit.distance < 8)
                {
                    rb.velocity = new Vector3(0f, 4f, 9f);
                }

                if (hit.distance > 8 && hit.distance < 10)
                {
                    rb.velocity = new Vector3(0f, 2f, 20f);
                }
            };

        }
    }

    // Update is called once per frame
    void Update()
    {
       // Vector3 currentPosition = 
    }
}

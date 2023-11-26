using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngineInternal;

public class bulletSpawner3 : MonoBehaviour
{

    [SerializeField]
    bullets bulletsPrefab;

    [SerializeField]
    Transform rayOrigin;

    [SerializeField]
    InputAction fireAction;

    [SerializeField]
    capsuleBullets capsuleBulletsPrefab;

    [SerializeField]
    private AudioSource gunShot;

    private LineRenderer lineRenderer;
    private Material bulletMaterial;
    private Transform importedSize;
    private int objType;

    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();

        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
        lineRenderer.material.color = Color.red;
    }

    private void FixedUpdate()
    {

        lineRenderer.SetPosition(0, new Vector3(0, 0, 0));
        lineRenderer.SetPosition(1, new Vector3(0, 0, 0));

        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit))
        {
            Debug.DrawRay(rayOrigin.position, rayOrigin.forward * hit.distance, Color.red);
            //Debug.Log(rayOrigin.position.x);
            lineRenderer.SetPosition(0, rayOrigin.position);
            lineRenderer.SetPosition(1, rayOrigin.forward * 10f);

            fireAction.performed += (obj) =>
            {
                Transform size;
                Rigidbody rb;
                Renderer r;
                gunShot.Play();

                if (objType == 0)
                {
                    // pewpew = gun noise
                    bullets pewpew = GameObject.Instantiate(bulletsPrefab, rayOrigin.position, rayOrigin.rotation);
                    size = pewpew.GetComponent<Transform>();
                    size.localScale = importedSize.localScale;
                    rb = pewpew.GetComponent<Rigidbody>();
                    r = pewpew.GetComponentInChildren<Renderer>();
                    r.material = bulletMaterial;
                }
                else
                {
                    capsuleBullets pewpew = GameObject.Instantiate(capsuleBulletsPrefab, rayOrigin.position, capsuleBulletsPrefab.GetComponentInChildren<Transform>().rotation);
                    size = pewpew.GetComponent<Transform>();
                    size.localScale = importedSize.localScale;
                    rb = pewpew.GetComponent<Rigidbody>();
                    r = pewpew.GetComponentInChildren<Renderer>();
                    r.material = bulletMaterial;
                }
                // pewpew = gun noise 

                Debug.Log(hit.distance);

                if (hit.distance <= 0)
                {
                    rb.velocity = new Vector3(0f, 2f, 5f);
                }
                if (hit.distance < 2 && hit.distance > 0)
                {
                    rb.velocity = (hit.point - rayOrigin.position).normalized * 10;
                    Debug.Log("1");

                }

                if (hit.distance > 2 && hit.distance < 4)
                {
                    rb.velocity = (hit.point - rayOrigin.position).normalized * 20;
                    Debug.Log("2");
                }

                if (hit.distance > 4 && hit.distance < 6)
                {
                    rb.velocity = (hit.point - rayOrigin.position).normalized * 30;
                    Debug.Log("3");
                }

                if (hit.distance > 6 && hit.distance < 8)
                {
                    rb.velocity = (hit.point - rayOrigin.position).normalized * 40;
                    Debug.Log("4");
                }

                if (hit.distance > 8 && hit.distance < 11)
                {
                    rb.velocity = (hit.point - rayOrigin.position).normalized * 50;
                    Debug.Log("5");
                }

            };

        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject canvas = GameObject.Find("Canvas");
        TestGUI testGuiScript = canvas.GetComponent<TestGUI>();
        bulletMaterial = testGuiScript.sharedMaterial;
        importedSize = testGuiScript.bulletSize;
        objType = testGuiScript.type;
    }

}
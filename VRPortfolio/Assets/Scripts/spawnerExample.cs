using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    GameObject spawnedCubePrefab;

    [SerializeField]
    GameObject spawnedSpherePrefab;

    [SerializeField]
    GameObject spawnedCapsulePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject spawnedCube = GameObject.Instantiate(spawnedCubePrefab);
            Rigidbody rbC = spawnedCube.GetComponent<Rigidbody>();
            rbC.velocity = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }

        if (Input.GetKeyDown(KeyCode.Backspace)) {
            GameObject spawnedSphere = GameObject.Instantiate(spawnedSpherePrefab);
            Rigidbody rbS = spawnedSphere.GetComponent<Rigidbody>();
            rbS.velocity = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameObject spawnedCapsule = GameObject.Instantiate(spawnedCapsulePrefab);
            Rigidbody rbCap = spawnedCapsule.GetComponent<Rigidbody>();
            rbCap.velocity = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f)); 
        }
    }
}

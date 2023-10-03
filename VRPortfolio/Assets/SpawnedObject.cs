using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    float lifeTime_s = 1;
    Color newColor = new Color(255, 0, 0);

    public GameObject cubes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime_s -= Time.deltaTime;

        if (lifeTime_s < 0) {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision) {
         GameObject.Destroy(gameObject);
    }

    private void OnTriggerStay(Collider other) {
        //cubes.GameObject.GetComponent<Renderer>().material.color = newColor;
        transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = newColor;
    }
}

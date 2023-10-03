using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedSphere : MonoBehaviour
{
    float lifeTime_s = 1;
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
}

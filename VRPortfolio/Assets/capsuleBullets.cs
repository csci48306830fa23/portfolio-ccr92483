using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleBullets : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject spawnPoint;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(gameObject);
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

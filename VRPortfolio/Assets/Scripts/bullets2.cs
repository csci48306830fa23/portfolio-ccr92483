using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class bullets2 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject spawnPoint;

    [SerializeField]
    private AudioSource shatterSound;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        shatterSound.Play();
        GameObject.Destroy(gameObject);
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

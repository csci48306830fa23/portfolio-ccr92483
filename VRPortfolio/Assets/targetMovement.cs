using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{

    [SerializeField]
    GameObject target1;

    private Vector3 target1LP;
    private Vector3 target1RP;

    private float slideTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        target1RP = new Vector3(-4.0f, 2.0983f, 9.51f);
        StartCoroutine(slide1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator slide1()
    {
        float startTime = 0f;
        Vector3 startingPos = target1.GetComponent<Transform>().position;

        while (startTime < slideTime)
        {
            target1.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target1RP, startTime / slideTime);
            startTime += Time.deltaTime;
            yield return null;
        }
        transform.position = target1RP;
    }

}

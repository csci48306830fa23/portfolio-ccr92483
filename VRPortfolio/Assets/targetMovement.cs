using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetMovement : MonoBehaviour
{

    [SerializeField]
    GameObject target1;

    [SerializeField]
    GameObject target2;

    [SerializeField]
    GameObject target3;

    [SerializeField]
    GameObject target4;

    [SerializeField]
    GameObject target5;

    private Vector3 target1P;
    private Vector3 target2P;
    private Vector3 target3P;
    private Vector3 target4P;
    private Vector3 target5P;

    private float slideTime = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        target1P = new Vector3(-4.0f, 2.0983f, 9.51f);
        target2P = new Vector3(-0.5f, 4.98f, 7.98f);
        target3P = new Vector3(1.0f, 7.39f, 6.61f);
        target4P = new Vector3(4.0f, 4.71f, 5.26f);
        target5P = new Vector3(6.5f, 2.0983f, 4.2f);
        StartCoroutine(slide1());
        StartCoroutine(slide2());
        StartCoroutine(slide3());
        StartCoroutine(slide4());
        StartCoroutine(slide5());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator slide1()
    {
        float startTime = 0f;
        Vector3 startingPos = target1.GetComponent<Transform>().position;

        while (true)
        {

            while (startTime < slideTime)
            {
                target1.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target1P, startTime / slideTime);
                startTime += Time.deltaTime;
                yield return null;
            }
            transform.position = target1P;
            startTime = 0f;
            target1P = startingPos;
            startingPos = target1.GetComponent<Transform>().position;

           
        }
    }

    IEnumerator slide2()
    {
        float startTime = 0f;
        slideTime = 4f;
        Vector3 startingPos = target2.GetComponent<Transform>().position;

        while (true)
        {

            while (startTime < slideTime)
            {
                target2.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target2P, startTime / slideTime);
                startTime += Time.deltaTime;
                yield return null;
            }
            transform.position = target2P;
            startTime = 0f;
            target2P = startingPos;
            startingPos = target2.GetComponent<Transform>().position;


        }
    }

    IEnumerator slide3()
    {
        float startTime = 0f;
        slideTime = 3f;
        Vector3 startingPos = target3.GetComponent<Transform>().position;

        while (true)
        {

            while (startTime < slideTime)
            {
                target3.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target3P, startTime / slideTime);
                startTime += Time.deltaTime;
                yield return null;
            }
            transform.position = target3P;
            startTime = 0f;
            target3P = startingPos;
            startingPos = target3.GetComponent<Transform>().position;


        }
    }

    IEnumerator slide4()
    {
        float startTime = 0f;
        slideTime = 2f;
        Vector3 startingPos = target4.GetComponent<Transform>().position;

        while (true)
        {

            while (startTime < slideTime)
            {
                target4.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target4P, startTime / slideTime);
                startTime += Time.deltaTime;
                yield return null;
            }
            transform.position = target4P;
            startTime = 0f;
            target4P = startingPos;
            startingPos = target4.GetComponent<Transform>().position;


        }
    }

    IEnumerator slide5()
    {
        float startTime = 0f;
        slideTime = 2f;
        Vector3 startingPos = target5.GetComponent<Transform>().position;

        while (true)
        {

            while (startTime < slideTime)
            {
                target5.GetComponent<Transform>().position = Vector3.Lerp(startingPos, target5P, startTime / slideTime);
                startTime += Time.deltaTime;
                yield return null;
            }
            transform.position = target5P;
            startTime = 0f;
            target5P = startingPos;
            startingPos = target5.GetComponent<Transform>().position;


        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallax : MonoBehaviour
{
    [SerializeField] Camera Cam;
    [SerializeField] Transform subject;

    Vector2 startPosition;
    float startZ;

    Vector2 travel => (Vector2)Cam.transform.position - startPosition;
    Vector2 parallaxFactor;

    void Start()
    {
        subject = GameObject.Find("Player").transform;

        startPosition = transform.position;
        startZ = transform.position.z;

        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + travel;
    }
}

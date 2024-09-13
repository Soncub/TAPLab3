using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    [SerializeField] private float orbitSpeed = 20f;
    [SerializeField] private Transform orbitTarget;
    private Vector3 axis;

    // Update is called once per frame
    void Update()
    {
        axis = orbitTarget.position;
        transform.RotateAround(axis, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}

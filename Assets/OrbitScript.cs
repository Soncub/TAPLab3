using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    [SerializeField] private float orbitSpeed = 20f;
    [SerializeField] private GameObject orbitTarget;
    private Vector3 axis;
    [SerializeField] private bool reverse = false;

    void Start()
    {
        if (reverse == true)
        {
            orbitSpeed = -1 * orbitSpeed;
        }
    }

    void Update()
    {
        axis = orbitTarget.transform.position;
        transform.RotateAround(axis, Vector3.forward, orbitSpeed * Time.deltaTime);
    }
}

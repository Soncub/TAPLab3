using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit2Script : MonoBehaviour
{
    [SerializeField] private float orbitMinSpeed = 10f;
    [SerializeField] private float orbitMaxSpeed = 40f;
    [SerializeField] private Transform orbitTarget;
    private Vector3 axis;
    private float targetStartDistance;
    [SerializeField] private bool reverse = false;

    void Start()
    {
        float targetStartDistance = Vector2.Distance(orbitTarget.transform.position, transform.position);

        if (reverse == true)
        {
            orbitMinSpeed = -1 * orbitMinSpeed;
            orbitMaxSpeed = -1 * orbitMaxSpeed;
        }
    }

    void Update()
    {
        axis = orbitTarget.position;
        float targetDistance = Vector2.Distance(orbitTarget.transform.position, transform.position);
        //speedCoefficient
        float speedScale = Mathf.InverseLerp(targetStartDistance, 0f, targetDistance);
        //must find way to make this account for when player distance is greater than targetStartDistance, and must be clamped

        transform.RotateAround(axis, Vector3.forward, Mathf.Lerp(orbitMaxSpeed, orbitMinSpeed, speedScale) * Time.deltaTime);
    }
}

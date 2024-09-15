using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    [SerializeField] private float orbitSpeed = 20f;
    [SerializeField] private GameObject orbitTarget;
    private Vector3 axis;
    private float targetStartDistance;
    [SerializeField] private bool reverse = false;

    void Start()
    {
        targetStartDistance = Vector2.Distance(orbitTarget.transform.position, transform.position);

        if (reverse == true)
        {
            orbitSpeed = -1 * orbitSpeed;
        }
    }

    void Update()
    {
        //get ratio of initial player distance to current distance
        float targetDistance = Vector2.Distance(orbitTarget.transform.position, transform.position);
        float speedScale = Mathf.InverseLerp(targetStartDistance, 0f, targetDistance);

        axis = orbitTarget.transform.position;
        transform.RotateAround(axis, Vector3.forward, (speedScale * orbitSpeed * Time.deltaTime));
        //                                                 ^ratio is now the coefficient of the orbit speed

        float speed = speedScale * orbitSpeed;
        Debug.Log("speedScale:" + speedScale);
    }
}
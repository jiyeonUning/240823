using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerController : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float maxRotateSpeed;
    [SerializeField] float accelerate;
    [SerializeField] float decelerate;

    public float RotateSpeed { get { return rotateSpeed; } }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    public void SpeedUp()
    {
        rotateSpeed += accelerate * Time.deltaTime;

        if (rotateSpeed > maxRotateSpeed)
        {
            rotateSpeed = maxRotateSpeed;
        }
    }

    public void SpeedDown()
    {
        rotateSpeed -= decelerate * Time.deltaTime;

        if (rotateSpeed < 0)
        {
            rotateSpeed = 0;
        }
    }
}

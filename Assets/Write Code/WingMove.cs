using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingMove : MonoBehaviour
{
    public float rotateSpeed;
    public float rotateAccelate;

    public float maxRotateSpeed;
    public float minRotateSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
    
    public void SpeedUp()
    {
        rotateSpeed += rotateAccelate * Time.deltaTime;

        if (rotateSpeed > maxRotateSpeed)
        {
            rotateSpeed = maxRotateSpeed;
        }
    }
    public void SpeedDown()
    {
        rotateSpeed -= rotateAccelate * Time.deltaTime;

        if (rotateSpeed < minRotateSpeed)
        {
            rotateSpeed = minRotateSpeed;
        }
    }
}

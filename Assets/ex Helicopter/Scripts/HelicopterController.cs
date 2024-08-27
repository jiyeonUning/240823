using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    [SerializeField] PropellerController propeller;

    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float flyToSpeed;

    private void Update()
    {
        Move();
        Fly();
    }

    private void Move()
    {
        if (transform.position.y <= 0)
            return;

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime);
    }

    private void Fly()
    {
        if (Input.GetButton("Jump"))
        {
            propeller.SpeedUp();
        }
        else
        {
            propeller.SpeedDown();
        }

        transform.Translate(Vector3.up * (propeller.RotateSpeed - flyToSpeed) / 100 * Time.deltaTime);

        float posY = Mathf.Clamp(transform.position.y, 0, 50);
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMove : MonoBehaviour
{
    [SerializeField] WingMove move;
    [SerializeField] float wingRotateValue;

    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            move.SpeedUp();
        }
        else
        {
            move.SpeedDown();
        }

        if (move.rotateSpeed > wingRotateValue)
        { MoveUp(); }
        else
        { MoveDown(); }
    }

    public void MoveUp()
    {
        transform.Translate(Vector3.up * (move.rotateSpeed - wingRotateValue ) / 100 * Time.deltaTime);

        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.up * (move.rotateSpeed - wingRotateValue) / 100 * Time.deltaTime);

        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

    }
}

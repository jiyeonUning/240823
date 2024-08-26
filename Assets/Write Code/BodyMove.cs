using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;

    private void Update()
    {

        float x = Input.GetAxis("Horizontal"); // A,D�� �¿� ������
        float z = Input.GetAxis("Vertical"); // W, S�� ���� ������

        // ������ ���� ���
        transform.Translate(Vector3.right * z * moveSpeed * Time.deltaTime, Space.Self);
        // ȸ�� ���
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);
    }
}

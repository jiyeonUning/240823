using UnityEngine;

public class WingMove : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float maxRotateSpeed;
    [SerializeField] float accelerate;
    [SerializeField] float decelerate;

    public float RotateSpeed { get { return rotateSpeed;  } }

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // ȸ�����
    }

    // �����緯 �ӵ� ���
    public void SpeedUp()
    {
        rotateSpeed += accelerate * Time.deltaTime;

        // ȸ���ӵ��� �ְ�ȸ���ӵ��� �Ѿ �� ���� if��
        if (rotateSpeed > maxRotateSpeed) { rotateSpeed = maxRotateSpeed; }
    }

    // �����緯 �ӵ� ����
    public void SpeedDown()
    {
        rotateSpeed -= decelerate * Time.deltaTime;

        // ȸ���ӵ��� 0���� �۾����� �ʰ� �������ν�, ���� ���� ���Ϸ� �������� �ʰ� ���ִ� if��
        if (rotateSpeed < 0) { rotateSpeed = 0; }
    }
}

using UnityEngine;

public class BodyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        // <������ ����>
        float x = Input.GetAxis("Horizontal"); // A,D�� �¿� ������
        float z = Input.GetAxis("Vertical"); // W, S�� ���� ������

        // ������ ����
        transform.Translate(Vector3.right * z * moveSpeed * Time.deltaTime, Space.Self);
        // �¿� ȸ��
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);

        //==================================================================================

        Fly(); // �Ʒ� �Լ� ���� ����
    }
    [SerializeField] WingMove propeller;
    [SerializeField] float flySpeed;

    void Fly()
    {
        // <���� ������ ����>

        // �����̽��� ���� ��, �����緯 ȸ���ӵ� ���� / �׷��� ���� ��, �����緯 ȸ���ӵ� ����
        if (Input.GetButton("Jump"))
        {
            propeller.SpeedUp();
        }
        else
        {
            propeller.SpeedDown();
        }

        // �������� ����ϴ� ��� ( = �����̵� )
        transform.Translate(Vector3.up * (propeller.RotateSpeed - flySpeed) / 100 * Time.deltaTime);

        // �ִ� ��� ���̸� �����ϰ�, (��ġ 50���� ����)
        float posY = Mathf.Clamp(transform.position.y, 0, 50);
        // �ش� ���� ���̸�ŭ�� ����� �� �ְ� ���ش�.
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }
}

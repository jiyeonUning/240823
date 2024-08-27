using UnityEngine;

public class BodyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        // <움직임 구현>
        float x = Input.GetAxis("Horizontal"); // A,D로 좌우 움직임
        float z = Input.GetAxis("Vertical"); // W, S로 상하 움직임

        // 전진과 후진
        transform.Translate(Vector3.right * z * moveSpeed * Time.deltaTime, Space.Self);
        // 좌우 회전
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);

        //==================================================================================

        Fly(); // 아래 함수 구현 참고
    }
    [SerializeField] WingMove propeller;
    [SerializeField] float flySpeed;

    void Fly()
    {
        // <공중 움직임 구현>

        // 스페이스바 누를 시, 프로펠러 회전속도 증가 / 그러지 않을 시, 프로펠러 회전속도 저하
        if (Input.GetButton("Jump"))
        {
            propeller.SpeedUp();
        }
        else
        {
            propeller.SpeedDown();
        }
    }

}

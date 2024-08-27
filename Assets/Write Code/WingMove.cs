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
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // 회전기능
    }

    // 프로펠러 속도 상승
    public void SpeedUp()
    {
        rotateSpeed += accelerate * Time.deltaTime;

        // 회전속도가 최고회전속도를 넘어갈 수 없는 if문
        if (rotateSpeed > maxRotateSpeed) { rotateSpeed = maxRotateSpeed; }
    }

    // 프로펠러 속도 저하
    public void SpeedDown()
    {
        rotateSpeed -= decelerate * Time.deltaTime;

        // 회전속도가 0보다 작아지지 않게 해줌으로써, 일정 높이 이하로 떨어지지 않게 해주는 if문
        if (rotateSpeed < 0) { rotateSpeed = 0; }
    }
}

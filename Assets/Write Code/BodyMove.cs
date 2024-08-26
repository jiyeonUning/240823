using UnityEngine;

public class BodyMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;

    private void Update()
    {

        float x = Input.GetAxis("Horizontal"); // A,D로 좌우 움직임
        float z = Input.GetAxis("Vertical"); // W, S로 상하 움직임

        // 전진과 후진 기능
        transform.Translate(Vector3.right * z * moveSpeed * Time.deltaTime, Space.Self);
        // 회전 기능
        transform.Rotate(Vector3.up, x * rotateSpeed * Time.deltaTime, Space.World);

        //==================================================================================

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

    [SerializeField] WingMove move;
    [SerializeField] float wingRotateValue;

    public void MoveUp()
    {
        transform.Translate(Vector3.up * (move.rotateSpeed - wingRotateValue) / 100 * Time.deltaTime);

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

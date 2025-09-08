using UnityEngine;

public class BallController : MonoBehaviour
{
    // 공의 이동 속도
    public float moveSpeed = 10f;

    private Rigidbody rb;

    // Start 메서드는 스크립트가 로드될 때 한 번 호출됩니다.
    void Start()
    {
        // Rigidbody 컴포넌트를 가져옵니다.
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate는 물리 계산을 위해 일정한 시간 간격으로 호출됩니다.
    void FixedUpdate()
    {
        // 수평(Horizontal) 및 수직(Vertical) 입력 값을 가져옵니다.
        float h = Input.GetAxis("Horizontal"); // A, D, 왼쪽/오른쪽 화살표 키
        float v = Input.GetAxis("Vertical");   // W, S, 위/아래 화살표 키

        // 입력 값에 따라 공에 힘을 가합니다.
        // AddForce는 Rigidbody에 지속적인 힘을 추가합니다.
        rb.AddForce(new Vector3(h, 0, v) * moveSpeed);
    }
}
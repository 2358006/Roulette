using UnityEngine;
public class RouletteController : MonoBehaviour
{
    private float fRotSpeed = 0f; // 회전속도
    public float fSlowDown = 0.98f; // 감속 계수

    void Start()
    {
        // 게임 화면을 60프레임 으로 고정함
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 클릭하면 회전속도를 설정함 
        if (Input.GetMouseButtonDown(0))
        {
            this.fRotSpeed = 10f;
        }

        // 회전속도 만큼 룰렛을 회전함
        transform.Rotate(0, 0, this.fRotSpeed);

        // 룰렛을 감속함
        this.fRotSpeed *= fSlowDown;
    }
}
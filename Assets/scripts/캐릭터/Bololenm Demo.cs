using UnityEngine;
//불(bool) 데이터 타입 = 논리  자료형, 참(ture) 또느ㄴ 거깃 (fales) 값만 저장
public class BololenmDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[불] bool형 변수 선언하고 초기화
        bool bln = true;
        bool isout = false;

        //[2]사용하기
        Debug.Log("bln 변수는 참(true)입니다.");
        Debug.Log("isout 변수는 거짓(false)입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

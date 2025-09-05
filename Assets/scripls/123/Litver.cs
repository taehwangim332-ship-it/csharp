using UnityEngine;

public class Litver : MonoBehaviour
{
    // [1] 변수 만들기 (선언) - 클래스 필드로 선언
    int num;          // 정수형 변수
    double su;        // 실수형 변수
    bool flag;        // 부울형 변수
    string str;       // 문자열 변수
    char c;           // 문자형 변수

    // Start는 스크립트가 로드될 때 한 번 호출됩니다.
    void Start()
    {
        // [2] 변수에 값 저장 (할당)
        num = 1234;
        su = 3.14159;
        flag = true;
        str = "안녕하세요";
        c = 'a';

        // [3] 변수 사용하기 (콘솔에 출력)
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);
    }
}
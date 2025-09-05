using UnityEngine;

// 숫자 이외의 데이터 형식 :bool,char,string
// char(문자) 데이터 형식

public class characterDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] char형 변수 선언 및 초기화 
        char grade = 'A';
        char kor = '한';

        Debug.Log($"grade: {grade}"); // 추천하는 방법
        Debug.Log($"kor: {kor}");     // 추천하는 방법
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

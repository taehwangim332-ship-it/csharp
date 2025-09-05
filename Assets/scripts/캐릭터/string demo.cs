using Unity.Collections;
using UnityEngine;
// srring(문자열) 데이터 형식
public class stringdemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] string 변수 선언하고 초기화
        string name="홍길동";
        string muliLine = @"
             안녕하세요
             반갑습니다
             ";

        //[2] 사용하기
        Debug.Log("안녕하세요" + name + "입니다");
        Debug.Log(muliLine);
        */

        //문자열 보간법 (string Interpolation)
        string message = "문자열 보간법";
        string msg = string.Format("{0}님{1}","홍길동", "안녕하세요");

        Debug.Log("message: " + message); //문자열 +연산  
        Debug.Log($"message: {message}"); //문자열 보간법
        Debug.Log(msg);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

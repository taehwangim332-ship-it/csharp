using UnityEngine;

public class inceretnumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수으ㅣ 값을 1씩 증ㄱㅏ 
        //[1] 변수 선언 및 초기화
        int num = 10;
        num = num + num + 1;   //1식 증가식 
        Debug.Log(num); //11

        //정수형 변수의 값을 1씩 감소

        int number = 10;
        num = num + num - 1;
        Debug.Log(num); //9

        //축약해서 사용하기
        int x = 10;
        //x =x+1;
        x += 1;
        Debug.Log($"x:{x}");

        int a = 3;
        int b = 5;

        b -= a; //a씩 감산 누적식,감산 
        Debug.Log($"b:{b}");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

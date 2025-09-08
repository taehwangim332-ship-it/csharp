using UnityEngine;

public class hdtest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 만약 x가 10이면 "x 는 10입니다" 를 출력

        int x = 10;

        if (x == 10) ;

                Debug.Log("x는 10입니다");


        // 만약 x가 20이 아니면 "x는 20이 아닙니다"를 출력 

        if (x != 10) ;

        Debug.Log("x는 20이아닙니다");





        // 문자열비교
        string s1 = "hello";
        string s2 = "hello";

        //만약 s1과 s2가 같으면 same 이라고 출력 
        if (s1 == s2) ;

        Debug.Log("same");



        //부정
        bool b1n = false;

        //!b1n 값이 참이면 실행문을 실행 
        if (!b1n == false)





            //실행문
            Debug.Log($"bin: !false - > true");



        string name = "홍길동";
        int age = 20;

        //이름이 홍길동과 같으면 실행 명령문 실행 

        if (name == "홍길동")

            if (age == 20)


                Debug.Log($"이름은 {name}, 나이는 {age}");





        // if and
        int number = 1234;

        //조건 : number 가 1234와 같냐?, number가 1000이상이냐?
        //두가지 조건을 모두  만족하면 (&&)"맞습니다" 출력 

        if (number == 1234 && number >= 1000) // ture && ture >= ture
            
            
            Debug.Log("맞습니다");

        //조건 : number가 1234와 같냐? number가 1000이하이냐?
        //두가지 조건중 하나라도 만족하면 "하나라도 참이면 참" 출력 

        if(number == 1234 && number <=1000);  //ture && false => true 

        Debug.Log("하나라도 참이면 참"); 















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

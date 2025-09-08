using UnityEngine;

public class sequerenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    
        

public class RotateObject : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {

            int kor = 100;
            int eng = 90;

            int total = 0; //총점
            double avg = 0.0; //평균 점수

            total = kor + eng; //중점 구하기
            avg = total / 2.0; //평균구하기 

            Debug.Log($"총점 :{total}");
            Debug.Log($"평균 :{avg:F1}");  // 소수점 첫째점까지만 출력 











            /*
             제어문 : 프로그램의 흐름(순서)를 정하는 명령문
            순차문
            조건문
            반복문
            기타:?*/





        }
    }

}

    // Update is called once per frame

 
  
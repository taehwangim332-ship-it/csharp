using UnityEngine;
// 만약 score 가 60이상이면 "합격" 이라고 출력 
public class hdDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 75; // 예시 점수. 이 값은 원하는 대로 변경 가능합니다.

        if (score >= 60)
        {
            Debug.Log("합격");
        }


        // 단문(실행문 1개) , 복문(실행문 2개 이상)

        // 단문 예제 
        Debug.Log("단문1");

        //if 문에서 {} 생략되면 if 문 바로 밑에 있는 명령문을 참일때 실행 
        //if문 바로 밑에있는 명령문 하나만 if문 실행문이 된다

        if (1 == 1);
        Debug.Log("단문 2");

        if (1 == 1) Debug.Log("단문 3");

        //복문 실행은 2부터 이상 
         



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

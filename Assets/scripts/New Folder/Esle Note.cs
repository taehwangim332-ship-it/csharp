using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
//만약 스코어가 60이상이면 "합격" 이라고 출력 
//아니면 "불합격"이라고 출력 
public class EsleNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    // 정수형 변수 score를 선언하고 0으로 초기화
    public int score = 0;

    // Start() 함수에서 한 번만 실행되도록 수정
    void Start()
    {
        // score가 60 이상이면 "합격" 출력
        if (score >= 60)
        {
            Debug.Log("합격");
        }
        else // 아니면 "불합격" 출력
        {
            Debug.Log("불합격");
        }
    }

}

// 입력 받은 first 와 second  값을 비교하여 큰 값을 출력 
// 만약 first 가 second 이상이면 frist 출력 


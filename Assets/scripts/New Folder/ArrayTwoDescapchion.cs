using UnityEngine;

public class ArrayTwoDescapchion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언 
        int[][] intArray = new int[2][];

        //[2] 두번째 요소수를 각각 따로 생성,초기화 
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 };

        //배열의 길이
        Debug.Log($"배열의 길기: {intArray.Length}");

        //[3] 배열의 요소를 출력 
        int[] playerScores = { 100, 250, 400, 550, 700 };

        // for문을 사용하여 배열의 모든 요소를 출력
        for (int i = 0; i < playerScores.Length; i++)
        {
            Debug.Log("플레이어 " + (i + 1) + "의 점수: " + playerScores[i]);
            int[] numbers = { 1, 2, 3 };

            int index = 0;


            Debug.Log(numbers[3]);



        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
            


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class Array2Note : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차열 배열 선언,요소수(크기),생성,초기화
        int[,] intArray = new int[2, 3] {{1,2,3 },{4,5,6 } };


        Debug.Log($"배열의 길이:{intArray.Length}");

        for (int i = 0; i < intArray.GetLength(0); i++) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class arraypractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*
 3행 3열의 2차원 배열을 만들고 아래와 같이 초기화 해주세요 
[3,3]
행과 열이 같으면 1, 행과 열이 틀리면 0으로 초기화

1,0,0,
0,1,0
0,0,1

*/
public class MatrixExample : MonoBehaviour
{
    void Start()
    {
        // 3행 3열의 2차원 배열 선언
        int[,] identityMatrix = new int[3, 3];

        // 반복문을 사용해 값 초기화
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (row == col)
                {
                    identityMatrix[row, col] = 1;
                }
                else
                {
                    identityMatrix[row, col] = 0;
                }
            }
        }

        // 초기화된 배열의 값 출력 (확인용)
        for (int row = 0; row < 3; row++)
        {
            string rowString = "";
            for (int col = 0; col < 3; col++)
            {
                rowString += identityMatrix[row, col] + " ";
            }
            Debug.Log(rowString);
        }
    }
}
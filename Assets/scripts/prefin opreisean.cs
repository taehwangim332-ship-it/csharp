using UnityEngine;
//전위 증감 연산자 : 같은 라인에서 연산하는 우선 순위가 가장 높다, 가장 먼저 연산 
public class prefinopreisean : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;

        int j = ++i;

        Debug.Log($"j:{j}");  //4
        Debug.Log($"i:{j}");
        
        
        int x = 3;
        
        int y = x++;
        
        Debug.Log($"x:{y}");  
        Debug.Log($"y:{x}");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

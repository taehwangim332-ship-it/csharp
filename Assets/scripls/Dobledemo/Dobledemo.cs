using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Dobledemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //[1]변수 선언 및 초기화
        float f = 3.14F;
        double d = 3.14D;
        decimal m = 3.14M;


        
        //[2]변수 사용
        Debug.Log(f);
        Debug.Log(d);
        Debug.Log(m);


        
    }
}
/*  
 실수형 데이터 형식

Float :32비트 부동 소수점 숫자 
Double : 64비트 부동  소수점 숫자 
Decimal : 128비트 부동  소수점 숫자 
*/
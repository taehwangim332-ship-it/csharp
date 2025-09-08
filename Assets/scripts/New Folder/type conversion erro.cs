using UnityEngine;
// 형식 변환 
public class typeconversionerro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //d를 더블형 변수로 선언하고 12.34를 저장
        double d = 12.34;     //64bit
        //i 를 int 형 변수로 선언하고 1234를 저장
        int i = 1234;           //32bit 

        // 묵시적(암묵적 ,암시적) 형식 변환 : double>int

        d = i;
        Debug.Log($"암시적 형식변환:{d}");

        d = 12.34;
        i = 1234;

        //[2] 명시적 형식 변환 int < double
        i = (int)d;
        Debug.Log($"명시적 형식변환:{d}");

        //[3] 수 이외 형식간 변환
        
        string s = "";//빈값으로 초기화
        s = d.ToString();
        Debug.Log($"형식변환:{s}");





    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}

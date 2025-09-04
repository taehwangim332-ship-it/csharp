using UnityEngine;

//변수(Variable): 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇 
public class Vaiananote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]변수 만들기 (선언)
        int i; // i 이름으로 (정수형) 변수 만들기

        //[2]변수의 값을 저장하기(대입,할당,초기화)
        i = 1234;

        //[3] 변수에 들어있는 값을 사용하기(참조)=사용하기 
        Debug.Log(i); // i에 들어있는 값을 출력하라 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

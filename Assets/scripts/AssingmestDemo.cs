using UnityEngine;
//할당(대입) 연산자 (=) :변수에 값을 저장 
public class AssingmestDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        int age = 19;
        Debug.Log($"이름은{name},나이는 {age}");



        /*
         +,- 등 다른 연산없이 변수 i,j,의 값을 서로 바꾸어서 저장하세요 
        hint) temp 변수를 만들어서 이용하세요

        [output]
        처음값i:100,j:200
        나중값 i:200,j:100       
        

        

        */
        //1. 변수 선언 및 초기화 
        int i=100;

        int j=200;

        int temp; // 임시 변수 temp설정 

        temp = i;
        i = j;

        j = temp;



        Debug.Log($"나중값 i:{i},j:{j}");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

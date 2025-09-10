using UnityEngine;

public class ArraytwcDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray;

        intArray = new int[2, 3];


        intArray[0, 0] = 1;
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;

        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

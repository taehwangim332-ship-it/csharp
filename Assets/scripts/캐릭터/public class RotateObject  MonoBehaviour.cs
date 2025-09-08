using UnityEngine;

public class publicclassRotateObjectMonoBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
        public class RotateObject : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            // Y축을 기준으로 초당 10도씩 회전
            transform.Rotate(0, 10 * Time.deltaTime, 0);
        }

    // Update is called once per frame
    
    
        
    }
}

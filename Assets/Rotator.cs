using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime 은 화면이 한번 깜박이는 시간 = 한 프레임의 시간
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 1 * Time.deltaTime);
    }
}

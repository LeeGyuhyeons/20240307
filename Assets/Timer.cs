using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time;
   

    // Start is called before the first frame update
    void Start()
    {
        time = 0;    
    }
    // 도착하기 전까지는 시간을 지속적을 체크합니다.
    // UI의 텍스트로 그 시간을 실시간으로 출력합니다

    private void Update()
    {
        if (GoalArea.goal == false)
        {
            time += Time.deltaTime;
        }
        //int t = (int)time;
        int t = Mathf.FloorToInt(time);
        //int t = Mathf.FloorToInt(time);

        Text text = GetComponent<Text>();
        text.text = "Time : " + t;
    }


}

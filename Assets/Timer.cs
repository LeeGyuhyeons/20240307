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
    // �����ϱ� �������� �ð��� �������� üũ�մϴ�.
    // UI�� �ؽ�Ʈ�� �� �ð��� �ǽð����� ����մϴ�

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

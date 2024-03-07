using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResuit : MonoBehaviour
{
    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;

    private void Start()
    {
        resultUI.SetActive(false);

        //�÷��̾� ������ : ����Ƽ���� �����͸� ������ �� ����ϴ� Ŭ����
        if (PlayerPrefs.HasKey("HighScore")) //�ش� Ű�� �����ϰ� �ִٸ�
        {
            highScore = PlayerPrefs.GetInt("HighScore"); // �� ������ �����մϴ�
        }
        else
        {
            highScore = 999; //������ ���� �⺻ ������ ó���մϴ�.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GoalArea.goal)//��ǥ ������ �������� ��
        {
            resultUI.SetActive(true);//��� UIâ�� Ȱ��ȭ�մϴ�
            int result = Mathf.FloorToInt(Timer.time);
            //Ÿ�̸ӿ��� ������ �ð��� �Ҽ����� ���� ������ ����� ��Ÿ��
            resultTime.text = "ResultTime : " + result;
            bestTime.text = "BestTime : " + highScore;
            //�ؽ�Ʈ�� ���� �����մϴ�
            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScor", result);
            }
        }
       
        
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

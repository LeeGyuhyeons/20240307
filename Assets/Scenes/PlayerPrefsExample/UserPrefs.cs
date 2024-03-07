using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UserPrefsEx : MonoBehaviour
{
    public InputField name_field;
    public InputField age_field;
    public InputField Height_field;
    public GameObject Message;

    private void Start()
    {
        SetMessage();
    }

    public void SetMessage()
    {
        Message.SetActive(false);
    }


    public void SaveInputField()
    {
        if (name_field.text != "" && age_field.text != "" && Height_field.text != "")
        {
            PlayerPrefs.SetString("UserName", name_field.text);
            PlayerPrefs.SetInt("UserAge", int.Parse(age_field.text));
            PlayerPrefs.SetFloat("UserHeight", float.Parse(Height_field.text));
            OnButtonExit("���� �Ϸ�!");

        }
        else
        {
            OnButtonExit("�ۼ��� ������ �����ϴ�");

        }
    }

    public void LoadInputField()
    {
        if(PlayerPrefs.HasKey("UserName") && PlayerPrefs.HasKey("UserAge") && PlayerPrefs.HasKey("UserHeight"))
        {
            name_field.text = PlayerPrefs.GetString("UserName");
            age_field.text = PlayerPrefs.GetInt("UserAge").ToString();
            Height_field.text = PlayerPrefs.GetFloat("UserHeight").ToString();

        }
        else
        {
            OnButtonExit("�ҷ��� �����Ͱ� �����ϴ�");

        }

    }
    public void OnButtonExit(string message)
    {
        Message.SetActive(true);
        Message.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }
}

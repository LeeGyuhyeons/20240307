using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField IdField;
    public InputField PWField;

    public GameObject SignUp;
    public GameObject LogIn;
    public GameObject LogOut;

    public GameObject Message2;


    public void Start()
    {
        SignUp.SetActive(true);
        LogIn.SetActive(true);
        LogOut.SetActive(false);
    }
    public void SetMessage()
    {
        Message2.SetActive(false);
    }

    public void OnButtonExit(string message)
    {
        Message2.SetActive(true);
        Message2.GetComponent<Text>().text = message;
        Invoke("SetMessage", 1.0f);
    }

    public void SignUpInputfield()
    {
        if (IdField.text != "" && PWField.text != "") 
        {
            PlayerPrefs.SetString("ID",IdField.text);
            PlayerPrefs.SetString("PassWord", PWField.text);
            OnButtonExit("ȸ������ ����!");

        }
        else
        {
            OnButtonExit("ȸ������ ���Ф�");
        }
    }

    public void LoginInputfield()
    {
        if (IdField.text != "" && PWField.text != "")
        {
            if (PlayerPrefs.GetString("ID") == IdField.text && PlayerPrefs.GetString("PassWord") == PWField.text)
            {
                OnButtonExit("�α��� ����!");
                LogIn.SetActive(false);
                LogOut.SetActive(true);
                SignUp.SetActive(false);

            }

            else
            {
                OnButtonExit("�α��� ���Ф�");

            }

        }
        else
        {
            OnButtonExit("�α��� ���Ф�");

        }

    }

    public void LogoutInputfield()
    {
        LogOut.SetActive(false);
        LogIn.SetActive(true);
        SignUp.SetActive(true);
        OnButtonExit("�α׾ƿ�!~");

    }

}

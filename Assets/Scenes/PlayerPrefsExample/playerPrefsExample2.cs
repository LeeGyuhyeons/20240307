using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefsExample2 : MonoBehaviour
{
    public PlayerData playerData;

    public void SaveData()
    {
        PlayerPrefs.SetInt("Player_HP", playerData.HP);
        PlayerPrefs.SetInt("Player_HP", playerData.MaxHP);
        PlayerPrefs.SetInt("Player_HP", playerData.attack);

    }

    public void LoadData()
    {
        playerData.HP = PlayerPrefs.GetInt("Player_HP");
        playerData.MaxHP = PlayerPrefs.GetInt("Player_MaxHP");
        playerData.attack = PlayerPrefs.GetInt("Player_Attack");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour 
{
    #region Public Members

    public  enum Sex { MALE, FEMALE, UNKNOWN };

    public  string  m_name;
    public  int     m_age;
    public  Sex     m_sex;

    #endregion

    #region Public void

        

    #endregion

    #region System

    void Start () 
    {
        Debug.Log(JsonUtility.ToJson(this));
        PlayerPrefs.SetString("Animals pref", JsonUtility.ToJson(this));
        Debug.Log(PlayerPrefs.GetString("Animals pref"));
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}

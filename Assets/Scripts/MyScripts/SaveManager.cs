using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("deapth", 0) == 0)
        {
            PlayerPrefs.SetInt("deapth", 1);
        }
        if (PlayerPrefs.GetInt("rings", 0) == 0 )
        {
            PlayerPrefs.SetInt("rings", 0);
        }
        
        if (PlayerPrefs.GetInt("scope1", 0) == 0)
        {
            PlayerPrefs.SetInt("scope1", 0);
        }
        
        if (PlayerPrefs.GetInt("scope2", 0) == 0)
        {
            PlayerPrefs.SetInt("scope2", 0);
        }
        
        if (PlayerPrefs.GetInt("scope3", 0) == 0)
        {
            PlayerPrefs.SetInt("scope3", 0);
        }
        
        if (PlayerPrefs.GetInt("scope4", 0) == 0)
        {
            PlayerPrefs.SetInt("scope4", 0);
        }

        if (PlayerPrefs.GetInt("level1", 0) == 0)
        {
            PlayerPrefs.SetInt("level1", 1);
        }
        if (PlayerPrefs.GetInt("level2", 0) == 0)
        {
            PlayerPrefs.SetInt("level2", 0);
        }
        
        
        if (PlayerPrefs.GetInt("level3", 0) == 0)
        {
            PlayerPrefs.SetInt("level3", 0);
        }
        if (PlayerPrefs.GetInt("level4", 0) == 0)
        {
            PlayerPrefs.SetInt("level4", 0);
        }
        
        if (PlayerPrefs.GetInt("level1") == 1)
        {    
            GameObject.Find("TextStatusLevel1").gameObject.GetComponent<Text>().text = "Open";
        }
        if (PlayerPrefs.GetInt("level2") == 1)
        {
            GameObject.Find("TextStatusLevel2").gameObject.GetComponent<Text>().text = "Open";
        }
        if (PlayerPrefs.GetInt("level3") == 1)
        {    
            GameObject.Find("TextStatusLevel3").gameObject.GetComponent<Text>().text = "Open";
        }
        if (PlayerPrefs.GetInt("level4") == 1)
        {
            GameObject.Find("TextStatusLevel4").gameObject.GetComponent<Text>().text = "Open";
        }
        Save();
    }

    private void Update()
    {
     //   Debug.Log("Level " + PlayerPrefs.GetInt("level1"));
        if (Input.GetKey(KeyCode.Space))
        {
            SaveUser(PlayerPrefs.GetInt("deapth") + 1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerPrefs.SetInt("scope1", PlayerPrefs.GetInt("scope1", 0) + 1);
            PlayerPrefs.Save();
        }
    }

    public void SaveUser(int deapth, int scope, int rings)
    {
        PlayerPrefs.SetInt("deapth", deapth);
        PlayerPrefs.SetInt("rings", rings);
        Save();
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
}

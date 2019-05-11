using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadStat : MonoBehaviour
{
    public string type;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt(type).ToString();
    }
}

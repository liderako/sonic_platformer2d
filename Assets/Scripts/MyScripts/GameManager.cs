using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scope;
    public int scope2;

    public float _time;
    
    public static GameManager gm;
    void Start()
    {
        _time = Time.time;
        scope = 0;
    }

    void Awake () {
        if (gm == null)
            gm = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        int a = (int)(Time.time - _time);
        GameObject.Find("TextScope").gameObject.GetComponent<Text>().text = "Rings : " + scope.ToString();
        GameObject.Find("TextTime").gameObject.GetComponent<Text>().text = "Time : " + a.ToString();
        GameObject.Find("TextScope (1)").gameObject.GetComponent<Text>().text = "Scope : " + scope2.ToString();
    }

    public int calcScope()
    {
        int a = (int)Time.time;
        int c = 20000 - a;
        if (c < 0)
        {
            c = 0;
        }
        return scope2 + scope * 100 + c;
    }
}

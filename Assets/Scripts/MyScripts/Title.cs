using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            SceneManager.LoadScene("DataSelect", LoadSceneMode.Single);
        }
    }
}

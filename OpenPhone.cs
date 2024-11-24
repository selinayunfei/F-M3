using UnityEngine;
using UnityEngine.SceneManagement;  // For UI components like Image and Button

public class OpenPhone: MonoBehaviour
{
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown("space")){
            SceneManager.LoadScene("Message");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class breakup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            SceneManager.LoadScene("Breakup");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
public class therapy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            SceneManager.LoadScene("Therapy");
        }
    }
}

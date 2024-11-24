using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToPhone : MonoBehaviour
{
    bool atdesk = false;
    bool invPhone = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        atdesk = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            SceneManager.LoadScene("Phone");
        }
    }

    IEnumerator waiter()
    {
        //Wait for 1 second
        if (atdesk == true){
            yield return new WaitForSeconds(2);
            atdesk = false;
            invPhone = true;
        }
    }

     void OnGUI()
    {
        var myFont = new GUIStyle();
        myFont.fontSize = 25;
        myFont.normal.textColor = Color.green;
        if (atdesk == true){
            GUI.Label(new Rect(10,10,200,50), "Wow, maybe I was the musician?", myFont);
            StartCoroutine(waiter());
        }
         if (invPhone == true){
            GUI.Label(new Rect(10,10,300,50), "I should check out the phone. (Press space!)", myFont);
        }
    }
}

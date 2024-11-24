using UnityEngine;

public class posterscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnGUI(){
            var myFont = new GUIStyle();
            myFont.fontSize = 25;
            myFont.normal.textColor = Color.green;
            GUI.Label(new Rect(10,10,200,50), "I was definitely a fan of this guy, huh...", myFont);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class textinteract : MonoBehaviour
{
    bool doorclick = false;
    bool doorchecked = false;
    bool gameStart = false;
    bool checkDoor = false;
    bool checkRoom = false;
    bool haskey = false;
    bool nokey = false;
    bool checkdesk = false;
    bool clickphone = false;
    bool endgame = false;
    private static bool posterchecked = false;
    private static bool deskchecked = false;
    private static bool closetchecked = false;
    public Camera MainCamera;
    private static bool hasInitialized = false;
    private static bool shelfChecked = false;
    private static bool reversechecked = false;
    private static bool letterfind = false;
    bool envCheck = false;
    private static bool envChecked = false;
    private static bool yearbook = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (hasInitialized == false){
                hasInitialized = true;
                gameStart = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
       {
            if (Input.GetMouseButtonDown(0)) 
            { 
                RaycastHit hit; 
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
                if (Physics.Raycast(ray, out hit)) 
                { 
                    if (hit.transform.name == "Door" ) 
                    {
                        doorclick = true;
                        doorchecked = true;
                        StartCoroutine(waiter());
                    } 
                    if (hit.transform.name == "Poster")
                    {
                        if (doorchecked == true){
                            SceneManager.LoadScene("Poster");
                            posterchecked = true;
                        }else if (envChecked == true){
                            SceneManager.LoadScene("ReversePoster");
                            envChecked = false;
                            reversechecked = true;
                        }
                    }
                    if (hit.transform.name == "maindrawer")
                    {
                        if (haskey == true){
                            SceneManager.LoadScene("Drawer");
                        }
                        else{
                            nokey = true;
                        }
                    }
                    if (hit.transform.name == "desktop")
                    {
                        if (posterchecked == true){
                            SceneManager.LoadScene("Desktop");
                            deskchecked = true;
                            posterchecked = false;
                        }
                    }
                    if (hit.transform.name == "Closet"){
                        if (deskchecked == true){
                            SceneManager.LoadScene("Journal1");
                            closetchecked = true;
                            deskchecked = false;
                        }
                    }
                    if (hit.transform.name == "Bookshelf"){
                        if (closetchecked == true){
                            shelfChecked = true;
                            closetchecked = false;
                            SceneManager.LoadScene("Stalker");
                            envChecked = true;
                        }else if (yearbook == true){
                            SceneManager.LoadScene("Yearbook");
                            yearbook = false;
                            haskey = true;
                        }
                    }

                    if (letterfind == true){
                        SceneManager.LoadScene("Letter");
                        yearbook = true;
                        letterfind = false;
                    }
                }
            }
        }
    }
    IEnumerator waiter()
    {
        //Wait for 1 second
        if (doorclick == true){
            yield return new WaitForSeconds(1);
            doorclick = false;
            checkRoom = true;
        }
        if (gameStart == true){
            yield return new WaitForSeconds(3);
            gameStart = false;
            checkDoor = true;
        }
        if (checkDoor == true){
            yield return new WaitForSeconds(2);
            checkDoor = false;
        }
        if (checkRoom == true){
            yield return new WaitForSeconds(1);
            checkRoom = false;
        }
        if (nokey == true){
            yield return new WaitForSeconds(1);
            nokey = false;
        }
        if (shelfChecked == true){
            yield return new WaitForSeconds (2);
            shelfChecked = false;
        }
        if (reversechecked == true){
            yield return new WaitForSeconds (3);
            reversechecked = false;
            letterfind = true;
        }
        if (haskey == true){
            yield return new WaitForSeconds(1);
        }
        if (endgame == true){
            haskey = false;
            yield return new WaitForSeconds(2);
        }
    }


    void OnGUI()
    {
        var myFont = new GUIStyle();
        myFont.fontSize = 25;
        myFont.normal.textColor = Color.green;
        if (gameStart == true){
            GUI.Label(new Rect(10,10,200,50), "Where am I?", myFont);
            StartCoroutine(waiter());
        }
        if (checkDoor == true){
            GUI.Label(new Rect(10,10,200,50), "I should check the door...", myFont);
            StartCoroutine(waiter());
        }
        if (checkRoom == true){
            GUI.Label(new Rect(10,10,200,50), "I should check the room...", myFont);
            StartCoroutine(waiter());
        }
        if (doorclick == true){
            GUI.Label(new Rect(10,10,200,50), "The door is locked.", myFont);
        }
        if (nokey == true){
            GUI.Label(new Rect(10,10,400,50), "This drawer needs a key... Maybe I should come back later.", myFont);
            StartCoroutine(waiter());
        }
        if (posterchecked == true){
            GUI.Label(new Rect(10,10,400,50), "I saw something on the table earlier. I'll go check it out.", myFont);
        }
        if (deskchecked == true){
            GUI.Label(new Rect(10,10,400,50), "Oh... I guess I wasn't a great person. I should look for the journal.", myFont);
        }
        if (closetchecked == true){
            GUI.Label(new Rect(10,10,400,50), "Wow, I seem so happy here. What happened? I should look for the picture.", myFont);
        }
        if (shelfChecked == true){
            GUI.Label(new Rect(10,10,400,50), "I crossed her face out... I guess we really did break up.", myFont);
            GUI.Label(new Rect(10,60,400,50), "There's an envelope underneath the picture.", myFont);
        }
        if (envChecked == true){
            GUI.Label(new Rect(10,10,400,50), "?! I have a stalker? These photos seem so scary...", myFont);
            GUI.Label(new Rect(10,60,400,50), "The window photo must be from behind the poster though. I'll investigate again.", myFont);
        }
        if (reversechecked == true){
            GUI.Label(new Rect(10,10,400,50), "Oh my god, I was a horrible person. I can't believe I did all of these things.", myFont);
            GUI.Label(new Rect(10,60,400,50), "Wait, is that a letter that fell out?", myFont);
            StartCoroutine(waiter());
        }
        if (yearbook == true){
            GUI.Label(new Rect(10,10,400,50), "...What does this letter mean? How do they know so much?", myFont);
            GUI.Label(new Rect(10,60,400,50), "...They'll be in the yearbook on the shelf. I should go check.", myFont);
        }
        if (haskey == true){
            GUI.Label(new Rect(10,10,400,50), "Prescription: 2010-11-29", myFont);
            StartCoroutine(waiter());
            GUI.Label(new Rect(10,60,400,50), "Date: 2010-12-01", myFont);
            StartCoroutine(waiter());
            GUI.Label(new Rect(10,110,400,50), "Pills left: 12/50", myFont);
            endgame = true;
        }
        if (endgame == true){
            myFont.fontSize = 100;
            myFont.normal.textColor = Color.green;
            GUI.Label(new Rect(400,250,400,400), "END GAME", myFont);
        }
    }
}

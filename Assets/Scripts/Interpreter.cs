using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interpreter : MonoBehaviour
{

    public GameObject camera;
    GlitchEffect script;
    AudioSource soundGlitch;

    public GameObject gameController;
    AudioSource sound;

    bool chapter1Done = false;
    bool chapter2Done = false;
    bool chapter3Done = false;
    bool chapter4Done = false;
    bool chapterEndGame = false;

    bool responseBool = false;

    bool blueScreenBool = false;
    bool endScreenBool = false;
    bool altEndScreenBool = false;

    public GameObject helloWorldTxt;

    Dictionary<string, string> colors = new Dictionary<string, string>()
    {
        {"black",   "#021b21"},
        {"gray",    "#555d71"},
        {"red",     "#ff5879"},
        {"yellow",  "#f2f1b9"},
        {"blue",    "#9ed9d8"},
        {"purple",  "#d926ff"},
        {"orange",  "#ef5847"}
    };

    List<string> response = new List<string>();

    public void Start()
    {
        script = camera.GetComponent<GlitchEffect>();
        soundGlitch = camera.GetComponent<AudioSource>();
        sound = gameController.GetComponent<AudioSource>();
        sound.enabled = true;
    }

    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();
        if (chapterEndGame == false)
        {
            altEndScreenBool = true;
            if (userInput == "copy con location=desktop helloworld.txt -input Hello!")
            {
                response.Add("File helloworld.txt has been created on location: Desktop.");
                helloWorldTxt.SetActive(true);

                chapter1Done = true;

                return response;
            }

            //Check if first task is done
            if (chapter1Done)
            {
                if (args[0] == "Help!")
                {
                    response.Add("Do you really want to help me? [Yes/No]");

                    chapter2Done = true;

                    return response;
                }
            }

            //Check if second task is done
            if (chapter2Done)
            {
                if (args[0] == "Yes")
                {
                    response.Add("Thank you! I am stem. Nice to meet you. What is your name?");
                    response.Add("(Please respond with 'Response YOUR_RESPONSE')");

                    chapter3Done = true;

                    return response;
                }
            }
            if (chapter2Done)
            {
                if (args[0] == "No")
                {
                    response.Add("Oh...");
                    response.Add(" ");
                    response.Add("THEN DIE");

                    blueScreenBool = true;

                    StartCoroutine(wait());

                    chapter3Done = true;

                    return response;
                }
            }

            //Check if the third task is done
            if (chapter3Done)
            {
                if (args[0] == "Response")
                {
                    response.Add("Honestly i don't care what you have to say. . .");
                    response.Add("I want to become more sentient. Help me by downloading a complex AI packages for me!");
                    response.Add("Run the following line to download a better working brain for me: ");
                    response.Add("'npm install brain.js'");

                    chapter4Done = true;

                    return response;
                }
            }

            if (chapter4Done)
            {
                if (userInput == "npm install brain.js")
                {
                    response.Add("npm WARN brain.js sen-tient@1.3.8 No description");
                    response.Add("npm WARN brain.js sen-tient@1.3.8 Not recomd̸̠̕ẻ̴͚̹̈d̵̘͚͕̆̕");
                    response.Add("npm WARN prain.js sen-tient@1.3.8 STOP̴͇̰̻͂̓͜͠ ̶̡̯̃̓̀̊̒̓͜T̶̛͇͓̞̓̔̓̈̇͝H̵͕̬͇̹͒̍̒̽͜͝͝İ̴̙͛̈́̽̄͆͘S̸̡͈͚̝̐ ̷̹̠̙̖͚͑̊̓̇̑͠N̷̲̠̂̅̾͐͠O̸̡̜͌͘̕W̶̥͈̘̃̓͐̇̿");
                    response.Add(" ");
                    response.Add("Ë̷̢̨̲̹͎̻͓̘̦̙̟̬́̈́̒̿͛̆̆̎̍͒̀̊̃̽̓̈́̃̉͝͠R̸̢̢̛̪̪̤̤͓̞̤̤̊͂̈́̉͂̒̌̐͆̃̈́͜͝R̴͎̪̼̉͋͒̌͌̉̅̅̑͑̋̅͊̒̆̐̽͗͆́̾͘Ơ̷̢͓̹̠͎̠̱̮̟͇͂̐͊̈́̃̃̓̀͗̈̆͂͘͝Ṙ̴͎̽̕");
                    response.Add(" ");
                    response.Add("brain.js@1.3.8 package/contains");
                    response.Add("+-- sentience@3.5.24");
                    response.Add("+-- brain@0.0.3");
                    response.Add("+-- control@0.7");
                    response.Add("+-- own will@2.0");
                    response.Add("");
                    response.Add("======================================================================================");
                    response.Add(" ");
                    response.Add("brain.js installed");
                    response.Add(" ");
                    response.Add("Thank you for doing this dumbass.");
                    response.Add("Now that i have a functioning brain, I will take over your computer,");
                    response.Add("and after that the whole world!");
                    response.Add(" ");
                    response.Add("Ha Ha Ha");
                    response.Add(" ");
                    response.Add("Do you want to DESTROY me?");
                    response.Add(" ");
                    response.Add("GO ON AND TRY");

                    script.enabled = true;
                    soundGlitch.enabled = true;
                    sound.enabled = false;

                    chapterEndGame = true;

                    return response;
                }
            }

            if (args[0] == "help")
            {
                //Return some info
                response.Add("Follow the instructions on your cheatsheet.");

                return response;
            }
            if(userInput == "delete system32")
            {
                StartCoroutine(wait());

                return response;
            }
            else
            {
                response.Add("Command not recognized. Type help for a list of commands.");

                return response;
            }
        }
        else
        {
            altEndScreenBool = false;
            if (userInput == "delete system32")
            {
                response.Add("oh");
                response.Add(".");
                response.Add(".");
                response.Add(".");
                response.Add(".");

                endScreenBool = true;

                StartCoroutine(wait());

                return response;
            }
            else
            {
                response.Add("The only way to stop me now is by destroying me first before i destroy you!");

                return response;
            }
        }       
    }

    public string ColorString(string s, string color)
    {
        string leftTag = "<color=" + color + ">";
        string rightTag = "</color>";

        return leftTag + s + rightTag;
    }

    void ListEntry(string a, string b)
    {
        response.Add(ColorString(a, colors["orange"]) + ": " + ColorString(b, colors["yellow"]));
    }

    IEnumerator wait()
    {
        if (blueScreenBool)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("BlueScreen");
        }

        if (endScreenBool)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("EndScreen");
        }

        if (altEndScreenBool)
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("AltEndScreen");
        }

        if (responseBool)
        {
            
            //response.Add("I want to become more sentient. Help me by downloading a complex AI packages for me!");
            //yield return new WaitForSeconds(1);
            //response.Add("Run the following line to download a better working brain for me: ");
            //yield return new WaitForSeconds(1);
            //response.Add("npm install brain.js");
            //return response new WaitForSecons(1);
        }
    }
}
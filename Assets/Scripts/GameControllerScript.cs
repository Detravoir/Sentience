using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControllerScript : MonoBehaviour
{
    bool cheatSheetIsOpen = false;
    bool CMDIsOpen = false;
    bool HelloWorldIsOpen = false;
    public GameObject cheatsheet;
    public GameObject cmd;
    public GameObject helloworld;

    void Start()
    {
        
    }


    public void Update()
    {   
        CheatSheetOpen();
        CMDOpen();
        HelloWorldOpen();
    }

    public void CheatSheetOpen()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            //Check if collides with tag: cheatsheetfile
            if (hit.collider.tag == "cheatsheeticon")
            {
                if (cheatSheetIsOpen == false)
                {
                    cheatSheetIsOpen = true;
                    //Debug.Log("Cheatsheet is visable");
                }
                else
                {
                    cheatSheetIsOpen = false;
                    //Debug.Log("Cheatsheet is NOT visable");
                }
                Debug.Log(cheatSheetIsOpen);
            }

            //Check if collides with tag: cheatsheetx
            if (hit.collider.tag == "cheatsheetx")
            {
                if (cheatSheetIsOpen == false)
                {
                    cheatSheetIsOpen = true;
                }
                else
                {
                    cheatSheetIsOpen = false;
                }
                Debug.Log(cheatSheetIsOpen);
            }
        }

        if (cheatSheetIsOpen == false)
        {
            cheatsheet.SetActive(false);
        }
        else
        {
            cheatsheet.SetActive(true);
        }
    }
    
    public void CMDOpen()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            //Check if collides with tag: cmdicon
            if (hit.collider.tag == "cmdicon")
            {
                if (CMDIsOpen == false)
                {
                    CMDIsOpen = true;
                    Debug.Log("Cheatsheet is visable");
                }
                else
                {
                    CMDIsOpen = false;
                    Debug.Log("Cheatsheet is NOT visable");
                }
                Debug.Log(CMDIsOpen);
            }

            //Check if collides with tag: cmdx
            if (hit.collider.tag == "cmdx")
            {
                if (CMDIsOpen == false)
                {
                    CMDIsOpen = true;
                }
                else
                {
                    CMDIsOpen = false;
                }
                Debug.Log(CMDIsOpen);
            }
        }

        if (CMDIsOpen == false)
        {
            cmd.SetActive(false);
        }
        else
        {
            cmd.SetActive(true);
        }
    }

    public void HelloWorldOpen()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            //Check if collides with tag: cheatsheetfile
            if (hit.collider.tag == "helloworldicon")
            {
                if (HelloWorldIsOpen == false)
                {
                    HelloWorldIsOpen = true;
                    //Debug.Log("Cheatsheet is visable");
                }
                else
                {
                    HelloWorldIsOpen = false;
                    //Debug.Log("Cheatsheet is NOT visable");
                }
                Debug.Log(HelloWorldIsOpen);
            }

            //Check if collides with tag: cheatsheetx
            if (hit.collider.tag == "helloworldx")
            {
                if (HelloWorldIsOpen == false)
                {
                    HelloWorldIsOpen = true;
                }
                else
                {
                    HelloWorldIsOpen = false;
                }
                Debug.Log(HelloWorldIsOpen);
            }
        }

        if (HelloWorldIsOpen == false)
        {
            helloworld.SetActive(false);
        }
        else
        {
            helloworld.SetActive(true);
        }
    }
}

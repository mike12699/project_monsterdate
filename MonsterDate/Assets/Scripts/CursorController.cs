using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Texture2D cursor;

    public Texture2D cursorClicked;

    private CursorControl controls;


    private void Awake()
    {
        ChangeCursor(cursor);
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    private void ChangeCursor(Texture2D cursorType)
    {

        controls = new CursorControl();

        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.Confined;
    }







    // Start is called before the first frame update
    private void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
    }
    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }
    private void EndedClick()
    {
        ChangeCursor(cursor);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject mothmanPanel;
    public GameObject bellatrixPanel;
    public GameObject eyevanPanel;
    public GameObject myraPanel;
    public GameObject skullyPanel;
    

    public void OpenMothman()
    {
        mothmanPanel.SetActive(true);
    }

    public void OpenBellatrix()
    {
        bellatrixPanel.SetActive(true);
    }

    public void OpenEyevan()
    {
        eyevanPanel.SetActive(true);
    }

    public void OpenMyra()
    {
        myraPanel.SetActive(true);
    }
    public void OpenSkully()
    {
        skullyPanel.SetActive(true);
    }
    public void CloseMothman()
    {
        mothmanPanel.SetActive(false);
    }
    public void CloseBellatrix()
    {
        bellatrixPanel.SetActive(false);
    }
    public void CloseEyevan()
    {
        eyevanPanel.SetActive(false);
    }
    public void CloseMyra()
    {
        myraPanel.SetActive(false);
    }
    public void CloseSkully()
    {
        skullyPanel.SetActive(false);
    }
}

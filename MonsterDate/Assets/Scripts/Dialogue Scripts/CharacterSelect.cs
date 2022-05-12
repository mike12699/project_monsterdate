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
    public GameObject skullyButton;
    

    public void OpenMothman()
    {
        mothmanPanel.SetActive(true);
        skullyButton.SetActive(false);
    }

    public void OpenBellatrix()
    {
        bellatrixPanel.SetActive(true);
        skullyButton.SetActive(false);
    }

    public void OpenEyevan()
    {
        eyevanPanel.SetActive(true);
        skullyButton.SetActive(false);
    }

    public void OpenMyra()
    {
        myraPanel.SetActive(true);
        skullyButton.SetActive(false);
    }
    public void OpenSkully()
    {
        skullyPanel.SetActive(true);
        skullyButton.SetActive(false);
    }
    public void CloseMothman()
    {
        mothmanPanel.SetActive(false);
        skullyButton.SetActive(true);
    }
    public void CloseBellatrix()
    {
        bellatrixPanel.SetActive(false);
        skullyButton.SetActive(true);
    }
    public void CloseEyevan()
    {
        eyevanPanel.SetActive(false);
        skullyButton.SetActive(true);
    }
    public void CloseMyra()
    {
        myraPanel.SetActive(false);
        skullyButton.SetActive(true);
    }
    public void CloseSkully()
    {
        skullyPanel.SetActive(false);
        skullyButton.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject mothmanPanel;
    public GameObject bellatrixPanel;
    public GameObject eyevanPanel;
    public GameObject myraPanel;
    
    public bool MothmanisActive;
    public bool BellatrixisActive;
    public bool EyevanisActive;
    public bool MyraisActive;
    

    public void TurnToMothman()
    {
        if (MothmanisActive == false)
        {
            bellatrixPanel.transform.gameObject.SetActive(false);
            eyevanPanel.transform.gameObject.SetActive(false);
            myraPanel.transform.gameObject.SetActive(false);
            mothmanPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            mothmanPanel.transform.gameObject.SetActive(false);
        }
    }

    public void TurnToBellatrix()
    {
        if (BellatrixisActive == false)
        {
            mothmanPanel.transform.gameObject.SetActive(false);
            eyevanPanel.transform.gameObject.SetActive(false);
            myraPanel.transform.gameObject.SetActive(false);
            bellatrixPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            bellatrixPanel.transform.gameObject.SetActive(false);
        }
    }

    public void TurnToEyevan()
    {
        if (EyevanisActive == false)
        {
            mothmanPanel.transform.gameObject.SetActive(false);
            bellatrixPanel.transform.gameObject.SetActive(false);
            myraPanel.transform.gameObject.SetActive(false);
            eyevanPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            eyevanPanel.transform.gameObject.SetActive(false);
        }
    }

    public void TurnToMyra()
    {
        if (MyraisActive == false)
        {
            mothmanPanel.transform.gameObject.SetActive(false);
            bellatrixPanel.transform.gameObject.SetActive(false);
            eyevanPanel.transform.gameObject.SetActive(false);
            myraPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            myraPanel.transform.gameObject.SetActive(false);
        }
    }
}

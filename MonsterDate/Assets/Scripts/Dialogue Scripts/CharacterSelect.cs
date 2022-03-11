using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject mothmanPanel;
    public GameObject askariosPanel;
    public bool MothmanisActive;
    public bool AskariosisActive;

    public void TurnToMothman()
    {
        if (MothmanisActive == false)
        {
            askariosPanel.transform.gameObject.SetActive(false);
            mothmanPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            mothmanPanel.transform.gameObject.SetActive(false);
        }
    }

    public void TurnToAskarios()
    {
        if (AskariosisActive == false)
        {
            mothmanPanel.transform.gameObject.SetActive(false);
            askariosPanel.transform.gameObject.SetActive(true);
        }
        else
        {
            askariosPanel.transform.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ScoreBar : MonoBehaviour
{
    public int maximum;
    public int current;

    public Image mask;
    public HUD scoreSet;
    





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    public void GetCurrentFill()
    {

        //int current = scoreSet.scoreText.ToString;
        
        float fillAmount = (float)current / (float)maximum;

        


        mask.fillAmount = fillAmount;
    }



}

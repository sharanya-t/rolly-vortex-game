using UnityEngine;
using UnityEngine.UI;
public class scoremanager : Spawner
{

    public Text scoreval;
    public GameObject hexscore;
    private static int score;
    // Update is called once per frame
    void Start()
    {
        int scr = vscore.scr;
        scoreval.text = scr.ToString("0");


    }
}

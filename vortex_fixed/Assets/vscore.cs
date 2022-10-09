
using UnityEngine;
using UnityEngine.UI;

public class vscore : MonoBehaviour
{
    public static int scr;
    public Text scoreval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scr = Spawner.score-10;
        
        if (scr < 0)
            scoreval.text = "0";
        else
            scoreval.text = scr.ToString();

    }
}

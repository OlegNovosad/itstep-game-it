using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cards : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI name_txt, rank_txt, time_txt, exper_txt, salary_txt;
    public Image happines_img;
    
    public List<Card> cards = new List<Card>();
    float max_h = 100f;
    float min_h = 0f;
    float calc_h = 0f;

    Card card0;
    public Gradient gradient;
    GradientColorKey[] gck = new GradientColorKey[3];
    GradientAlphaKey[] gak = new GradientAlphaKey[2];


    void Start()
    {
        gradient = new Gradient();

        gck[0].color = new Color32(129, 199, 132, 0);
        gck[0].time = 1.0f;
        gck[1].color = new Color32(253, 216, 53, 0);
        gck[1].time = 0.5f;
        gck[2].color = new Color32(229, 57, 53, 0);
        gck[2].time = 0.0f;

        gak[0].alpha = 1.0f;
        gak[0].time = 0.25f;
        gak[1].alpha = 1.0f;
        gak[1].time = 0.75f;
        gradient.SetKeys(gck, gak);


        if (cards.Count > 0)
        {
            card0 = cards[0];
            name_txt.text = card0.name;
            rank_txt.text = card0.rank;
            time_txt.text = card0.time.ToString() + hourCount(card0.time);
            exper_txt.text = card0.exper.ToString() + yearCount(card0.exper);
            salary_txt.text = card0.salary.ToString() + "\n$";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cards.Count > 0)
        {
            calc_h = card0.happiness / max_h;
            setHappiness(calc_h);
        }
        
    }

    string yearCount(int exper)
    {
        string year = "\nyears";

        if(exper == 1)
        {
            year = "\nyear";
        }

        return year;
    }

    string hourCount(int time)
    {
        string hour = "\nhours";
        if(time == 1)
        {
            hour = "\nhour";
        }
        return hour;
    }

    Color colorFromGradient(float value)
    {
        return gradient.Evaluate(value);
    }
    void setHappiness(float amount)
    {
        happines_img.fillAmount = amount;
        happines_img.color = colorFromGradient(calc_h);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Card
{
    public Image profile_img;
    public string name, rank;
    public int time, exper, salary;
    [Range(0,100)]
    public float happiness;
    public GameObject info_panel;



    public Card(string _name, string _rank, int _time, int _exper, int _salary, float _happiness, Image _profile_img)
    {
        name = _name;
        rank = _rank;
        time = _time;
        exper = _exper;
        salary = _salary;
        happiness = _happiness;
        profile_img = _profile_img;
    }

    public void showPanel()
    {
        info_panel.SetActive(true);
    }
}

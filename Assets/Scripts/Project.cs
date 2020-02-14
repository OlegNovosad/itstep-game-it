using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Project
{
    public GameObject project_card;
    public Sprite projectIcon_img;
    public string name;
    string duration_str;
    public int duration;
    string revenue_str;
    public int revenue;

    public Project(Sprite _project_icon_img, string _name, int _duration,  int _revenue)
    {
        projectIcon_img = _project_icon_img;
        name = _name;
        duration = _duration;
        revenue = _revenue;
    }
}

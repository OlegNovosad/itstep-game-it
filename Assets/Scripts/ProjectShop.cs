using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProjectShop : MonoBehaviour
{
    [SerializeField]
    List<Project> projects = new List<Project>();
    public Sprite[] icons = new Sprite[2];
    

    public GameObject project_card;
    public GameObject cards_list;
    public List<GameObject> cards = new List<GameObject>();
    public List<Vector3> cards_pos = new List<Vector3>();

    public TextMeshProUGUI name_txt, duration_txt, revenue_txt;

    float x = 0;
    float initial = 1.0f;
    float scale = 0.7f;

    int moveX = 7;

    public int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach(Project project in projects)
        {
            print(project.name + "\n" + project.duration);
        }

        projects.Add(new Project(icons[0], "1", 3, 25));
        projects.Add(new Project(icons[1], "2", 5, 50));
        projects.Add(new Project(icons[2], "2", 1, 50));

        for (int i = 0; i < projects.Count; i++)
        {
            cards.Add(Instantiate(project_card));

            //cards[i].transform.parent = cards_list.transform;
            cards[i].transform.SetParent(cards_list.gameObject.transform, false);

            
        }

        Transform icon;
        //Transform background;

        for(int i = 0; i < cards.Count; i++)
        {
            //cards[i].GetComponent<SpriteRenderer>().sprite = icon;

            //cards[i].transform.GetComponentInChildren<Image>().sprite = icons[i]; !!!!! DO NOT DELETE!!!

            icon = cards[i].transform.GetChild(1);
            icon.gameObject.GetComponent<Image>().sprite = icons[i];
            
        }

        /*background = cards[1].transform.GetChild(2);
        background.gameObject.GetComponent<Image>().color = new Color(0, 0, 0);*/

        

        //Resources.Load("Sprites/arrow_btn") as Image

        for(int i = 0; i < cards.Count; i++)
        {
            float y = cards[i].transform.position.y; // setting initial position
            cards[i].transform.position = new Vector2(x, y);
            Debug.Log(y);
            x += moveX;
        }

        foreach (GameObject card in cards)
        {
            cards_pos.Add(card.transform.position);
        }

        for(int i = 0; i < cards.Count; i++)
        {
            cards[i].gameObject.transform.localScale = new Vector3(scale, scale, scale);
        }
        cards[currentIndex].gameObject.transform.localScale = new Vector3(initial, initial, initial);

        setProjectData(currentIndex);
        setShadow(currentIndex);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && currentIndex > 0)
        {
            currentIndex -= 1;
            listController(1);
            setProjectData(currentIndex);
            
        } 
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentIndex < cards.Count-1)
        {
            currentIndex += 1;
            listController(-1);
            setProjectData(currentIndex);
        }


    }

    string spelling(int duration)
    {
        if(duration == 1)
        {
            return "week";
        }
        else
        {
            return "weeks";
        }
    }

    void setProjectData(int getIndex)
    {
        name_txt.text = projects[getIndex].name;
        duration_txt.text = projects[getIndex].duration.ToString() + " " + spelling(projects[getIndex].duration);
        revenue_txt.text = projects[getIndex].revenue.ToString() + " $";
    }

    

    void listController(int direction)
    {

        if (direction == 1)
        {

            for (int i = 0; i < cards.Count; i++)
            {
                cards[i].gameObject.transform.localScale = new Vector3(scale, scale, scale);
                cards_pos[i] = new Vector3(cards_pos[i].x + moveX, cards[i].transform.position.y);
                cards[i].gameObject.transform.position = new Vector3(cards_pos[i].x, cards_pos[i].y);
            }
            cards[currentIndex].gameObject.transform.localScale = new Vector3(1, 1, 1);
            setShadow(currentIndex);
        } 
        else if(direction == -1)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                
                cards[i].gameObject.transform.localScale = new Vector3(scale, scale, scale);
                cards_pos[i] = new Vector3(cards_pos[i].x - moveX, cards[i].transform.position.y);
                cards[i].gameObject.transform.position = new Vector3(cards_pos[i].x, cards_pos[i].y);
                //cards[i].gameObject.transform.position = Vector3.Lerp(transform.localPosition, cards_pos[i], 3.0f * Time.deltaTime);

            }
            cards[currentIndex].gameObject.transform.localScale = new Vector3(1, 1, 1);
            setShadow(currentIndex);


        }

        //cards[currentIndex].gameObject.transform.localScale -= new Vector3(scale, scale, scale);
    }

    void setShadow(int currentIndex)
    {
        Transform shadow;

        for(int i = 0; i < cards.Count; i++)
        {
            shadow = cards[i].transform.GetChild(2);
            shadow.gameObject.GetComponent<Image>().color = new Color(0, 0, 0);
        }

        shadow = cards[currentIndex].transform.GetChild(2);
        shadow.gameObject.GetComponent<Image>().color = new Color(255, 255, 255);
    }
}

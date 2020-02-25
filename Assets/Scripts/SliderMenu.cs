using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderMenu : MonoBehaviour
{
    public Scrollbar scrollbar;
    public List<GameObject> cards;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
        {
            if (scrollbar.GetComponent<Scrollbar>().value < 0.125f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0, 0.1f);
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.125f && scrollbar.GetComponent<Scrollbar>().value < 0.375f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.25f, 0.1f);
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.375f && scrollbar.GetComponent<Scrollbar>().value < 0.625f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.5f, 0.1f);
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.625f && scrollbar.GetComponent<Scrollbar>().value < 0.875f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.75f, 0.1f);
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.875f && scrollbar.GetComponent<Scrollbar>().value <= 1)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 1, 0.1f);
            }
        }
        if (scrollbar.GetComponent<Scrollbar>().value < 0.125f)
        {
            cards[0].transform.localScale = Vector2.Lerp(cards[0].transform.localScale, new Vector2(0.53f, 0.53f), 0.1f);
            cards[1].transform.localScale = Vector2.Lerp(cards[1].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[2].transform.localScale = Vector2.Lerp(cards[2].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[3].transform.localScale = Vector2.Lerp(cards[3].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[4].transform.localScale = Vector2.Lerp(cards[4].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
        }
        else if (scrollbar.GetComponent<Scrollbar>().value >= 0.125f && scrollbar.GetComponent<Scrollbar>().value < 0.375f)
        {
            cards[1].transform.localScale = Vector2.Lerp(cards[1].transform.localScale, new Vector2(0.53f, 0.53f), 0.1f);
            cards[0].transform.localScale = Vector2.Lerp(cards[0].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[2].transform.localScale = Vector2.Lerp(cards[2].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[3].transform.localScale = Vector2.Lerp(cards[3].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
            cards[4].transform.localScale = Vector2.Lerp(cards[4].transform.localScale, new Vector2(0.45f, 0.45f), 0.1f);
        }
    }
}

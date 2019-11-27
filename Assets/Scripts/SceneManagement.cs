using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public List<GameObject> button_list = new List<GameObject>();
    public List<string> load = new List<string>();

    public Image black;
    public Animator anim;

    void Start()
    {


        foreach (GameObject go in button_list)
        {
            int index = button_list.IndexOf(go);
            go.GetComponent<Button>().onClick.AddListener(() => StartCoroutine(ChangeScene(load[index], SceneManager.GetActiveScene().ToString()))); //Don't touch! :)

        }


    }

    private IEnumerator ChangeScene(string toLoad, string toUnload)
    {
        anim.SetBool("Fade", true);
        //Debug.Log("Starting Fade");
        yield return new WaitUntil(() => black.color.a == 1);

        yield return SceneManager.LoadSceneAsync(toLoad);
        yield return SceneManager.UnloadSceneAsync(toUnload);
    }
}

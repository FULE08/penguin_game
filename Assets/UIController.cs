using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    Player player;
    Text distanceText;

    GameObject results;
    Text finalDistanceText;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();

        finalDistanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();
        results = GameObject.Find("Results");
        results.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + " cm";

        if (player.isDead)
        {
            results.SetActive(true);
            finalDistanceText.text = distance + " cm";
        }
	}

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

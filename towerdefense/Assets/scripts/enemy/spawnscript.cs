using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class spawnscript : MonoBehaviour
{
    [SerializeField] GameObject enemyprefab;
    [SerializeField] GameObject trooperprefab;
    public GameObject waypoint;
    public TextMeshProUGUI text;
    public int moneyCount;
    public bool canspawn;
    private List<GameObject> enemies;
    private GameObject enemy;
    public int enemyHp = 50;
    private WaypointFollower wpfs;
    
    // Start is called before the first frame update
    
    void Start()
    {
        text = TextMeshProUGUI.FindObjectOfType<TextMeshProUGUI>();
        waypoint = GameObject.FindGameObjectWithTag("waypointenemy");
        StartCoroutine(spawnenemy());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnenemy()
    {
        while (true) 
        {

            
            
            //enemies.Add(Instantiate(enemyprefab));
            enemy = Instantiate(enemyprefab);
            enemy.transform.position= waypoint.transform.position;
            

            wpfs = enemy.GetComponent<WaypointFollower>();
            //enemies[enemies.Count - 1].transform.position = transform.position;
            yield return new WaitForSeconds(10.5f);
        }
        
    }
  
    public void spawntroop()
    {
        
        if(canspawn)
        {
            
            text.text = "money : " + moneyCount;
            GameObject troopknight = Instantiate(trooperprefab);
            troopknight.transform.position = waypoint.transform.position;
        }
        if(moneyCount <= 100)
        {
            
            canspawn = false;
        }
       


    }
    public void moneyfunction(int money)
    {
        moneyCount += money;
    }

}

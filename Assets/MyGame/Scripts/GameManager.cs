using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] targets;
    public GameObject parentOfTargets;
    public GameObject winSprite;
    public Text scoreText;
    
    private int score = 0;
    private bool win = false;

    private void Start()
    {
        InvokeRepeating("Spawn",1f,1f);
    }

    private void Update()
    {
        

        //every shoot (clicking left mouse button) produce a shooting sound.
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        
    }

    //Spawn a target at a random position within a specified x and y range.
    //Instantiate (make a concrete GameObject, i.e., a clone from the given prefeb target) the target as a child
    //of the GameObject ParentTargets. In this case transform.localPosition instead of transform.position is important!!
    private void Spawn()
    {
        Debug.Log("Neues Target wird erstellt!");
        float randomX = Random.Range(-365f, 365f);
        float randomY = Random.Range(-202f,202f);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

         if (targets == null || targets.Length == 0)
    {
        Debug.LogError("No targets assigned!");
        return;
    }


        int randomIndex = Random.Range(0, targets.Length);

        GameObject newTarget = Instantiate(targets[randomIndex], parentOfTargets.transform);


        newTarget.transform.localPosition = random2DPosition;
        
    }

    //is called in the class Target
    public void IncrementScore(int points)
    {
        score += points;
        print(score);

        scoreText.text = score.ToString();

        if (score >= 20)
        {
            CancelInvoke("Spawn");
            win = true;
            winSprite.SetActive(true);
        }
    }
}

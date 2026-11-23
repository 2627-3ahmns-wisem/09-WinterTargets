using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    private float direction;
    private bool isMoving = false;
    public float minX = -365f;
    public float maxX = 365f;

    private void Start()
    {
        //create a reference to the GameManager script
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        isMoving = Random.value < 0.3f;
        speed = Random.Range(50f, 280f);
        direction = Random.value < 0.5f ? -1f : 1f;
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        if (isMoving)
        {
            Vector3 position = transform.localPosition;

            position.x += direction * speed * Time.deltaTime;

            if (position.x >= maxX)
            {
                position.x = maxX;
                direction = -1f;
            }
            else if (position.x <= minX)
            {
                position.x = minX;
                direction = 1f;
            }

            transform.localPosition = position;
        }
    }

    private void OnMouseDown()
    {
        //call the IncrementScore() method from the GameManager Script
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
}

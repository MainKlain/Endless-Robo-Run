using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RobotsScript : MonoBehaviour
{
    public Vector2 targetPos;
    public float Yincrement;
    public float speed;

    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;
    public TextMeshProUGUI healthDisplay;

    public GameObject gameOver;

    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}

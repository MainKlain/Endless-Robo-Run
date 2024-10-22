using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSkinManagerScript : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject Player;

    private Sprite playersprite;

    private void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;

        Player.GetComponent<SpriteRenderer>().sprite = playersprite;
    }
}
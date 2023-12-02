using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    [SerializeField] SceneController controller;

    private int _id;
    public int Id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    void Start()
    { }

    void Update()
    { }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.CanReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}

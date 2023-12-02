using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class UIButton : MonoBehaviour
{
    [SerializeField] SceneController controller;

    public Color highlightColor = Color.cyan;

    void Start()
    { }

    void Update()
    { }

    public void OnMouseEnter()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void OnMouseUp()
    {
        transform.localScale = Vector3.one;
        if (controller != null)
        {
            controller.Restart();
        }
    }
}

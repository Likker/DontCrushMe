using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArrowButton : CustomButton
{
    public Direction dir;
    PlayerController player;
    public Text label;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    public void OnMouseDown(Direction dir)
    {
        label.text = transform.name;
        player.Move(dir);
    }

    public override void OnMouseDown()
    {
        OnMouseDown(Direction.LEFT);
    }
}

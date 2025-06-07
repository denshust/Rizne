using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class CreateWindow : MonoBehaviour
{
    public Button dragon;
    public Button goblin;
    public Button red;
    public Button gold;

    private BaseEnemyFactory factory;

    private RedFactory redFactory;
    private GoldFactory goldFactory;

    private void Start()
    {
        redFactory = new RedFactory(); 
        goldFactory = new GoldFactory();

        SetRed();

        dragon.onClick.AddListener(CreateDragon);
        goblin.onClick.AddListener(CreateGoblin);
        red.onClick.AddListener(SetRed);
        gold.onClick.AddListener(SetGold);
    }


    private void SetRed()
    {
        factory = redFactory;
    }
    private void SetGold()
    {
        factory = goldFactory;
    }

    private void CreateDragon()
    {
        Dragon dragon = factory.CreateDragon();
    }
    private void CreateGoblin()
    {
        Goblin goblin = factory.CreateGoblin();
    }
}

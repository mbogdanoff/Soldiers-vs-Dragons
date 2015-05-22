﻿using UnityEngine;
using System.Collections;

public class Level10 : Levels
{

    public static bool isLevelCompleted = false;

    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;

    // Use this for initialization
    void Start()
    {
        addEnemy(dragonFly, 14);
        addEnemy(dragonFly, 15);

        addEnemy(dragonFly, 21);
        addEnemy(dragonFly, 23);
        addEnemy(dragonFly, 25);

        addEnemy(dragonWarrior, 30);

        addEnemy(dragonKnight, 32);
        addEnemy(dragonFly, 34);
        addEnemy(dragonWarrior, 36);
        addEnemy(dragonFly, 38);

        addEnemy(dragonWarrior, 44, 1);
        addEnemy(dragonWarrior, 44, 3);
        addEnemy(dragonKnight, 46);
        addEnemy(dragonFly, 47);
        addEnemy(dragonWarrior, 48);
        addEnemy(dragonFly, 49);
        addEnemy(dragonWarrior, 50);
        addEnemy(dragonFly, 51);

        addEnemy(dragonKnight, 53, 2);
        addEnemy(dragonFly, 54, 2);

        addEnemy(dragonWarrior, 55);
        addEnemy(dragonWarrior, 56);
        addEnemy(dragonWarrior, 57);
        addEnemy(dragonFly, 55);
        addEnemy(dragonKnight, 56);
        addEnemy(dragonKnight, 57);

        addEnemy(dragonWarrior, 58);
        addEnemy(dragonFly, 59);
        addEnemy(dragonWarrior, 60);
        addEnemy(dragonKnight, 61, 2);
        addEnemy(dragonFly, 62, 3);
        addEnemy(dragonFly, 62, 4);
        addEnemy(dragonKnight, 62, 1);

        addEnemy(dragonWarrior, 62, 2);
        addEnemy(dragonFly, 63);
        addEnemy(dragonWarrior, 64);
        addEnemy(dragonKnight, 65, 2);
        addEnemy(dragonFly, 66);
        addEnemy(dragonKnight, 67, 2);
    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint iceTower;
    public TurretBlueprint poisonTower;
    public TurretBlueprint fireTower;
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectIceTower()
    {
        buildManager.SelectTurretToBuild(iceTower);
    }
    public void SelectPoisonTower()
    {
        buildManager.SelectTurretToBuild(poisonTower);
    }
    public void SelectFireTower()
    {
        buildManager.SelectTurretToBuild(fireTower);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        instance = this;
    }
    //controls building towers
    public GameObject IceTowerPrefab;
    public GameObject PoisonTowerPrefab;
    public GameObject FireTowerPrefab;
    private TurretBlueprint turretToBuild;
    private BuildNode selectedNode;
    public NodeUI nodeUI;
    //property that is only allowed to be gotten from
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }
    //get location to build turret
    public void BuildTurretOn(BuildNode node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            return;
        }
        PlayerStats.Money -= turretToBuild.cost;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }
    public void SelectNode(BuildNode node)
    {
        selectedNode = node;
        turretToBuild = null;
        nodeUI.SetTarget(node);
    }
    //get selected turret
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        selectedNode = null;
    }
}

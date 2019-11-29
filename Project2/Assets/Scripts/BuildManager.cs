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
    public GameObject IceTowerPrefab;
    private GameObject turretToBuild;
    void Start()
    {
        turretToBuild = IceTowerPrefab;
    }
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}

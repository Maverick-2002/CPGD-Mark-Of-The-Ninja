using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health PlayerHealthNinja;
    [SerializeField] private Health PlayerHealthRonin;
    [SerializeField] private Image TotalHealthBar;
    [SerializeField] private Image CurrentHealthBar;
    public GameObject CameraTargetPrefab;
    void Start()
    {
        if (CameraTargetPrefab.activeInHierarchy)
        {
            TotalHealthBar.fillAmount = PlayerHealthNinja.currenthealth / 10;
        }
        else
        {
            TotalHealthBar.fillAmount = PlayerHealthRonin.currenthealth / 10;
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraTargetPrefab.activeInHierarchy)
        {
            CurrentHealthBar.fillAmount = PlayerHealthNinja.currenthealth / 10;
        }
        else
        {
            CurrentHealthBar.fillAmount = PlayerHealthRonin.currenthealth / 10;
        }
    }
}

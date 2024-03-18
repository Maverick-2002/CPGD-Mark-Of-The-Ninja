using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    private int SelectionOpt;
    public CharacterDB CharacterDB;
    public GameObject[] skins;
    private void Awake()
    {
        foreach (GameObject obj in skins)
        {
            obj.SetActive(false);
        }
    }
    public void Nextoption()
    {
        SelectionOpt++;
        if (SelectionOpt >= CharacterDB.charactercount)
        {
            SelectionOpt = 0;
            Debug.Log(SelectionOpt);

        }
        UpdateCharacter(SelectionOpt);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            SelectionOpt = 0;
        }
        else
        {
            Load();
        }
        Debug.Log(SelectionOpt);
        UpdateCharacter(SelectionOpt);
        skins[SelectionOpt].SetActive(true);
    }
    private void Load()
    {
        SelectionOpt = PlayerPrefs.GetInt("selectedOption");
    }
    private void UpdateCharacter(int SelectionOpt)
    {
        Character character = CharacterDB.GetCharacter(SelectionOpt);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

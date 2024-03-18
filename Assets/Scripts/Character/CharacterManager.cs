using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public GameObject Selection,Menu;
    public CharacterDB CharacterDB;
    public Text Cname;
    public SpriteRenderer pic;
   

    private int SelectionOpt = 0;
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
        Debug.Log(SelectionOpt);
        save();



    }
    public void BackOpt()
    {
        SelectionOpt--;
        if (SelectionOpt < 0)
        {
            SelectionOpt = CharacterDB.charactercount - 1;
            
        }
       // Debug.Log(SelectionOpt);
        save();

    }
    private void UpdateCharacter(int SelectionOpt)
    {
        Character character = CharacterDB.GetCharacter(SelectionOpt);
        pic.sprite = character.charactersprite;
        Cname.text = character.charactername;
    } 
    
    private void Load()
    {
        SelectionOpt = PlayerPrefs.GetInt("selectedOption");

    }
    private void save()
    {
        PlayerPrefs.SetInt("selectedOption", SelectionOpt);
    }   
    public void Home()
    {
        Selection.SetActive(false);
        Menu.SetActive(true);
    }

}

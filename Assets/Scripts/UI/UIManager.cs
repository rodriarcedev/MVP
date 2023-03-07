using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    public GameObject panelEnable;
    // Start is called before the first frame update

    private void Awake()
    {

    }
    void Start()
    {
        FindObjectOfType<PlayerHealth>().OnEnemyDeath += ShowPanel;
    }
    public void ShowPanel()
    {
        panelEnable.SetActive(true);
    }
    public void HidePanel()
    {
        panelEnable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

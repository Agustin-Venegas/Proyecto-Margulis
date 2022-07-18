using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour
{
    public Text title;
    public Text Info;
    public Image icon;
    public GameObject panel;
    public Image button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Molecule m = hit.collider.gameObject.GetComponent<IHelpClickable>().GetMoleculeInfo();
                Assign(m);
            }
        }
    }

    void OnEnable()
    {
        panel.SetActive(false);
    }

    void Assign(Molecule m)
    {
        panel.SetActive(true);
        Info.text = m.info;
        icon.sprite = m.representation;
    }

    void Turn()
    {
        enabled = !enabled;

        if (enabled) button.color = Color.grey; else button.color = Color.white;
    }
}

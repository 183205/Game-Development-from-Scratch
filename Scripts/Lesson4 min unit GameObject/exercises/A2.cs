using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TypeB
{
    //¸ÄÃû
    changeName,
    //Ê§»î
    ActiveFlase,
    //ÑÓ³ÙÉ¾³ý
    DeleyDes,
    //É¾³ý
    Des,
}
public class A2 : MonoBehaviour
{
    public GameObject B;
    public TypeB type = TypeB.changeName;
    // Start is called before the first frame update
    void Start()
    {
        switch (type)
        {
            case TypeB.changeName:
                B.name = "³¬¼¶ÎÞµÐÓîÖæÉñÁú";
                break;
            case TypeB.ActiveFlase:
                B.SetActive(false);
                break;
            case TypeB.DeleyDes:
                Destroy(B,5);
                break;
            case TypeB.Des:
                DestroyImmediate(B);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

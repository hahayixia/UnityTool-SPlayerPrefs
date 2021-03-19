using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerData : SStruct
{
    public PlyerData(string key)
    {
        Init(new UnityStorage(), key);
    }
    [SDef(100)]
    public SInt id;
    [SDef("aaa")]
    public SString name;
    [SDef(10f)]
    public SFloat time;
    public GoodsItem curgoods;
    public SLinkList<GoodsItem> allgoods;
}

public class GoodsItem : SStruct
{
    public SInt id;
    public SString name;
    public SInt num;
}

public class Example : MonoBehaviour
{
    public bool writedata;
    PlyerData data = null;
    // Start is called before the first frame update
    void Start()
    {
        data = new PlyerData("example");

        if (writedata)
        {
            data.id.Value = 10;
            data.name.Value = "hahayixia";
            data.time.Value = 10.5f;
            data.curgoods.id.Value = 1;
            data.curgoods.name.Value = "blood";
            data.curgoods.num.Value = 1;

            GoodsItem item = data.allgoods.AddLast();

            item.id.Value = 2;
            item.name.Value = "blood2";
            item.num.Value = 1;
        }

        Debug.Log("Show Data:");
        Debug.Log("data.id.Value:" + data.id.Value);
        Debug.Log("data.name.Value:" + data.name.Value);
        Debug.Log("data.time.Value:" + data.time.Value);
        Debug.Log("data.curgoods.id.Value:" + data.curgoods.id.Value);
        Debug.Log("data.curgoods.name.Value:" + data.curgoods.name.Value);
        Debug.Log("data.curgoods.num.Value:" + data.curgoods.num.Value);
        Debug.Log("data.allgoods");
        int index = 0;
        data.allgoods.ForEach((d) =>
        {
            Debug.Log("data.allgoods:"+ index);
            Debug.Log("d.id.Value:" + d.id.Value);
            Debug.Log("d.name.Value:" + d.name.Value);
            Debug.Log("d.num.Value:" + d.num.Value);
            index++;
            return true;
        });
    }
}



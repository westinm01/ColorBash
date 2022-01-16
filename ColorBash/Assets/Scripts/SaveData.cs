using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveStat
{
  public static void SaveStats()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.stats";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);


    }
}

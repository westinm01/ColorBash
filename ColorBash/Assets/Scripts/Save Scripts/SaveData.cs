using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveData : MonoBehaviour
{
  public static void SaveInfo()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.stats";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

        SaveType data = new SaveType(Info.points, Info.circles, Info.backgrounds, Info.highScore);

        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static SaveType LoadInfo()
    {
        string path = Application.persistentDataPath + "/save.stats";
        if (!File.Exists(path))
        {
            Debug.LogError("Save file doesn't exist/can't be found: " + path);
            return null;
        }
        else
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveType data = formatter.Deserialize(stream) as SaveType;
            stream.Close();

            Info.points = data.points;
            Info.circles = data.circles;
            Info.backgrounds = data.backgrounds;

            return data;
        }

    }
}

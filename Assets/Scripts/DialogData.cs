using UnityEngine;

[System.Serializable]
public class DialogEntry
{
    public string characterName;  // Nama karakter
    public Sprite characterSprite;  // Sprite karakter
    public string dialogText;  // Teks dialog
    public string position;  // Posisi karakter: "left", "right", "center"
}

[CreateAssetMenu(fileName = "NewDialog", menuName = "Dialog System/Dialog Data")]
public class DialogData : ScriptableObject
{
    public DialogEntry[] entries;  // Array dialog
}
using UnityEngine;

[System.Serializable]
public class DialogEntry
{
    public string characterName;        // Nama karakter
    public Sprite[] characterSprites;     // Sprite karakter
    public string dialogText;             // Teks dialog
    public int[] speakingCharacterIndices; // Indeks karakter yang berbicara
    public Vector3[] positions;           // Posisi masing-masing karakter
    public string[] animationTriggers;    // Trigger animasi karakter
}

[CreateAssetMenu(fileName = "NewDialog", menuName = "Dialog System/Dialog Data")]
public class DialogData : ScriptableObject
{
    public DialogEntry[] entries;  // Array dialog
}
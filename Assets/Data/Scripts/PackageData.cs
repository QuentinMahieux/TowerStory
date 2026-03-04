using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PackageData", menuName = "Scriptable Objects/PackageData")]
public class PackageData : ScriptableObject
{
    [Header("Générale Information")]
    public DeliveryNumber deliveryNumber;
    public string name;
    public string description;
    public Sprite icon;
    
    [Header("Package Dialogue")]
    public List<PakageDialogue> listPakageDialogues;
    
    [Header("PNJ Element Unlock")]
    public List<QuestionData> newQuestions;
    public List<PackageData> newPackages;
}

[System.Serializable]
public class PakageDialogue
{
    public DeliveryNumber deliveryNumber;
    public List<string> dialogueReponses;
}

public enum DeliveryNumber
{
    N06,
    N13,
    N10,
    N03,
    N2
}
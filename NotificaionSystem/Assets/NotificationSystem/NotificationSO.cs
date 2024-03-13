using UnityEngine;

[CreateAssetMenu(menuName = "Notification", fileName = "New Notification")]
public class NotificationSO : ScriptableObject
{
    [Header("Text")]
    public string name;
    public string description; 
    public string message;
    [Header("Visual")]
    public Sprite icon;
    public Color backgroundColor;
    [Header("Audio")]
    public AudioClip audio;
    [Header("Time")]
    public float lifeTime;
    [Header("Prefab")]
    public GameObject prefab;
}

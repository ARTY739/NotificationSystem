using UnityEngine;

public class NotificationsManager : MonoBehaviour
{
    public static NotificationsManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }

    public void SendNotification(NotificationSO notification, Transform notificationWindow)
    {
        NotificationUI notificationUI = Instantiate(notification.prefab, notificationWindow).GetComponent<NotificationUI>();
        notificationUI.notificationSO = notification;
    }
}

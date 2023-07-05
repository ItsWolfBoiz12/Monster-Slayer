using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassSelectionManager : MonoBehaviour
{
    private DatabaseManager databaseManager;

    private void Start()
    {
        databaseManager = GetComponent<DatabaseManager>();
    }

    public void SelectAssassin()
    {
        string selectedClass = "Assassin";
        databaseManager.RetrieveClassData(selectedClass);
        // Additional logic specific to selecting the Warrior class
        // For example, store the selected class in a player data object

        ChangeScene();
    }

    public void SelectKnight()
    {
        string selectedClass = "Knight";
        databaseManager.RetrieveClassData(selectedClass);
        // Additional logic specific to selecting the Mage class
        // For example, store the selected class in a player data object

        ChangeScene();
    }

    public void SelectSage()
    {
        string selectedClass = "Sage";
        databaseManager.RetrieveClassData(selectedClass);
        // Additional logic specific to selecting the Rogue class
        // For example, store the selected class in a player data object

        ChangeScene();
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }
}

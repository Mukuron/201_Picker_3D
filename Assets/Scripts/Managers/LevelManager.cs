using UnityEngine;


 public class LevelManager : Monobehaviour
 {

        #region Self Veriables


        #endregion

        #region Serialized Veiables

        [SerializeField] private int totalLevelCount, LevelID;
        [SerializeField] private Transform levelHolder;
    

        #endregion

        #region Private Veriables

        private CD_Level _levelData;

        private OnLevelLoaderCommand _levelLoaderCommand;
        private OnLevelDestroyerCommand _levelDestroyerComand;

        #endregion
       
        private void Awake()
        {
           _levelData = GetLevelData();
           levelID = GetActiveLevel();
           Init();
        }
        
        private int GetActiveLevel() 
        {
          if (ES3.FileExists())
          {
            if (ES3.KeyExists("Level"))
            {
                return ES3.Load<int>(key: "Level");
            }

          }

          return 0;

        }

    private CD_Level GetLevelData() => Resources.Load<CD_Level>(path: "Data/CD_Level");

    private void Init()
    {
        _levelLoaderCommand = new OnLevelLoaderCommand(levelHolder);
    }

    private void InitializeLevel()
    {
        _levelLoaderCommand.Execute(levelID);
    }

    private void ClearActiveLevel()
    {
        _levelDestroyerComand.Execute();
    }

 }


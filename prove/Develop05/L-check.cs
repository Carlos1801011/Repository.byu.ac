
public class CheckListGoal : Goal 
{

    private int _currentlyCounterActually;
    private int _verificationC;
    private int _bonusGoal;
    private bool _checked = false;

     public CheckListGoal(string goalName, string goalDescription, int pointsArchieved, int verificationCounter, int bonusGoalCompleted, int currentCounter = 0, bool Goalchecked = false) : base(goalName, goalDescription, pointsArchieved)
    {

        _titleName = goalName;
        _description = goalDescription;
        _pointsToCompleteTotal = pointsArchieved;
        _verificationC = verificationCounter;
        _bonusGoal = bonusGoalCompleted;
        _currentlyCounterActually = currentCounter;
        _checked = Goalchecked;
    }

    public int GetVerificationCounter()
    {
        return _verificationC;
    }
    public void SetVerificationCounter(int verificationCounterToSet)
    {
        _verificationC = verificationCounterToSet;
    }
    public int GetBonusGoalCompleted()
    {
        return _bonusGoal;
    }
    public void SetBonusGoalCompleted(int bonusGoalCompletedToSet)
    {
        _bonusGoal = bonusGoalCompletedToSet;

    }
    public int GetCurrentlyCounter()
    {
        return _currentlyCounterActually;
    }
    public void SetCurrentlyCounter(int currenlyCounterToSet)
    {
        _currentlyCounterActually = currenlyCounterToSet;

    }    
    //Method to set this value to a list
    public override string GetGoalInformation()
    {
        if (_checked)
        {
            return $"[X] {_titleName} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationC}";
        }
        else
        {
            return $"[ ] {_titleName} ({_description}) -- Currently completed {GetCurrentlyCounter()}/{_verificationC}";
        }
    }


    public override int GetGoalCompleted(int userPoints)
    {

        _currentlyCounterActually = _currentlyCounterActually + 1;
        int currentCounter = _currentlyCounterActually;
        SetCurrentlyCounter(currentCounter);

        string goalInformation = GetGoalInformation();


        int index = _listOfGoals.IndexOf(goalInformation);
        string newGoalInformation;


        if (_currentlyCounterActually == _verificationC)
        {
            _checked = true;
            newGoalInformation = GetGoalInformation();

            userPoints = userPoints + _bonusGoal;
            userPoints = userPoints + _pointsToCompleteTotal;
        }
        else if (_currentlyCounterActually > _verificationC)
        {
            _currentlyCounterActually = _currentlyCounterActually - 1;
        }
        else
        {
            newGoalInformation = goalInformation;

            userPoints = userPoints + _pointsToCompleteTotal;
        }

        return userPoints;

    }

 
    public override string GetStringRepresentation()
    {
        return "CheckListGoal:" + _titleName + "," + _description + "," + _pointsToCompleteTotal + "," + _verificationC + "," + _bonusGoal + "," + _currentlyCounterActually;
    }
}
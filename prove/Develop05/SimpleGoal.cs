using System;

public class SimpleGoal : Goal 
{

    private bool _checked = false;
    private bool _completed = false;

    public SimpleGoal(string goalName, string goalDescription, int pointsArchieved, bool checkedGoal = false) : base(goalName, goalDescription, pointsArchieved)
    {
        _titleName = goalName;
        _description = goalDescription;
        _pointsToCompleteTotal = pointsArchieved;
        _checked = checkedGoal;
    }

    public override string GetGoalInformation()
    {
        {
            if (_checked){
                _completed = true;
                return "[X] " + _titleName + " (" + _description + ")";}
            else{
                return "[ ] " + _titleName + " (" + _description + ")";}
        }
    }


    public override int GetGoalCompleted(int userPoints)
    {

        bool completed = _completed;

        _checked = true;
        if (completed == false)
        {
            GetGoalInformation();

            userPoints = userPoints + _pointsToCompleteTotal;
            completed = true;
            return userPoints;
        }
        else
        {
            GetGoalInformation();
            return userPoints;
        }
        
    }
    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _titleName + "," + _description + "," + _pointsToCompleteTotal + "," + _checked;
    }
}
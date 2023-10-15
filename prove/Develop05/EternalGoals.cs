using System;

public class EternalGoal : Goal
{

    public EternalGoal(string goalName, string goalDescription, int pointsArchieved) : base(goalName, goalDescription, pointsArchieved)
    {
        _titleName = goalName;
        _description = goalDescription;
        _pointsToCompleteTotal = pointsArchieved;
    }
    //------------------ Constructors section --------------

        public override string GetStringRepresentation()
    {
        return "EternalGoal:" + _titleName + "," + _description + "," + _pointsToCompleteTotal;
    }


    public override int GetGoalCompleted(int userPoints)
    {
        GetGoalInformation();
        userPoints = userPoints + _pointsToCompleteTotal;
        return userPoints;
    }

        public override string GetGoalInformation()
    {
        return $"[ ] {_titleName} ({_description})";
    }

    


}
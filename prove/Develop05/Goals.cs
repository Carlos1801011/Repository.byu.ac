using System;

public abstract class Goal
{

    protected string _titleName;
    protected string _description;
    protected int _pointsToCompleteTotal;

    protected List<string> _listOfGoals = new List<string>();


    public Goal(string goalName, string goalDescription, int pointsArchieved)
    {

        _titleName = goalName;
        _description = goalDescription;
        _pointsToCompleteTotal = pointsArchieved;
    }

    public string GetGoalName()
    {

        return _titleName;
    }



    public string GetGoalDescription()
    {
        return _description;
    }

        public void SetGoalName(string goalName)
    {
        _titleName = goalName;
    }

        public int GetGoalPoints()
    {

        return _pointsToCompleteTotal;
    }
    
    public void SetGoalDescription(string goalDescription)
    {

        _description = goalDescription;
    }



    public void SetGoalPoints(int goalPointsToComplete)
    {

        _pointsToCompleteTotal = goalPointsToComplete;
    }
    //Getter & Setter section 


        public virtual int GetGoalCompleted(int userPoints){
        return userPoints;
    }    




    public virtual string GetGoalInformation(){
        return $"[] {_titleName} ({_description})";
    }
    


            
    //(to save in an external file like txt or cvs)
    public virtual string GetStringRepresentation()
    {
        return "Goal:" + _titleName + "," + _description + "," + _pointsToCompleteTotal + "," + false;
    }

}
Public Class ServoBase
{
    private int CurrentPosition;
    private int MoveToPosition;
    private int Channel;
    private int MinimumPosition;
    private int MaximumPosition;
    private decimal CenterPosition;

    public ServoBase(int channel, int minimumPosition, int maximumPosition, InitialPosition initialPosition)
    {
        Channel = channel;
        MinimumPosition = minimumPosition;
        MaximumPosition = maximumPosition;
        CenterPosition = InitialPosition.Minimum ? MinimumPosition : InitialPosition.Maximum ? MaximumPosition : MinimumPosition + (maximumPosition - minimumPosition) / 2;
        CurrentPosition = CenterPosition;
    }

    public void MoveServo(int newPosition)
    {
        # This checks to make sure that the new position is not out of bounds of the servos range of motion.
        if(newPosition < minimumPosition || newPosition > maximumPosition)
        {
            throw new ArgumentOutOfRangeException(nameof(newPosition));
        }

# If the servo is currently moving, then set the move to position to the current position. This will then stop the servo.
if(CurrentPosition<>MoveToPosition){
    MoveToPosition = CurrentPosition;
}

# Set the move to position to the new position to start the servo moving.
        MoveToPosition = newPosition;
    }

public void ResetServoPosition(){
# If the servo is currently moving, then set the move to position to the current position. This will then stop the servo.
    if(CurrentPosition<>MoveToPosition){
        MoveToPosition=CurrentPosition;
    }

    MoveToPosition = CenterPosition;
}
}
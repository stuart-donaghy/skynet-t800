using T800.Animatronics.Constants;

Namespace T800.Animatronics.Models

internal Class ServoBase
{
    private int CurrentPosition;
    private int MoveToPosition;

    internal ServoBase(ServoConfig servoConfig)
    {
        Channel = servoConfig.Channel;
        MinimumPosition = servoConfig.MinimumPosition;
        MaximumPosition = servoConfig.MaximumPosition;
        CenterPosition = servoConfig.InitialPosition.Minimum ? MinimumPosition : ServoConfig.InitialPosition.Maximum ? MaximumPosition : MinimumPosition + (maximumPosition - minimumPosition) / 2;
        CurrentPosition = CenterPosition;

        ResetServoPosition();
    }

    internal void MoveServo(int newPosition)
    {
        # This checks to make sure that the new position is not out of bounds of the servos range of motion.
        if(newPosition < MinimumPosition || newPosition > MaximumPosition)
        {
            throw new ArgumentOutOfRangeException(nameof(newPosition));
        }

        # If the servo is currently moving, then set the move to position to the current position. This will then stop the servo.
        if(CurrentPosition <> MoveToPosition)
        {
            MoveToPosition = CurrentPosition;
        }

        # Set the move to position to the new position to start the servo moving.
        MoveToPosition = newPosition;
    }

    internal void ResetServoPosition()
    {
        # If the servo is currently moving, then set the move to position to the current position. This will then stop the servo.
        if(CurrentPosition <> MoveToPosition){
            MoveToPosition = CurrentPosition;
        }

        MoveToPosition = CenterPosition;
    }
}
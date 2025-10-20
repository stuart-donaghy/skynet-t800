using T800.Animatronics.Models;

namespace T800.Animatronics.Models;

internal class Eyes
{
    private Eye _leftEye;
    private Eye _rightEye;

    internal Eyes(Eye leftEye, Eye rightEye)
    {
        _leftEye = leftEye;
        _rightEye = rightEye;
    }

    internal Eye LeftEye => _leftEye;
    internal Eye RightEye => _rightEye;
}
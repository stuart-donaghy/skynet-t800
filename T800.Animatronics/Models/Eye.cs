namespace T800.Animatronics.Models;

internal class Eye
{
    private ServoBase _upDown;
    private ServoBase _leftRight
    private ServoBase _topEyelid;
    private ServoBase _bottomEyelid;
    private ServoBase _iris;

    internal Eye(ServoBase upDown, ServoBase leftRight, ServoBase topEyelid, ServoBase bottomEyelid, ServoBase iris)
    {
            _upDown = upDown;
            _leftRight = leftRight;
            _topEyelid = topEyelid;
            _bottomEyelid = bottomEyelid;
            _iris = iris;
    }

    internal ServoBase UpDown => _upDown;
    internal ServoBase LeftRight => _leftRight;
    internal ServoBase TopEyelid => _topEyelid;
    internal ServoBase BottomEyelid => _bottomEyelid;
    internal ServoBase Iris => _iris;
}
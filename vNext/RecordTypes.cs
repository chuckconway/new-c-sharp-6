//Current
class MyPoint
{
    int _x;
    int _y;
    int _z;
    MyPoint(int x, int y, int z){
        this._x = x;
        this._y = y;
        this._z = z;
    }
    public int X {get{ return this._x;}}
    public int Y {get{ return this._y;}}
    public int Z {get{ return this._z;}}
}


//Proposed
class Point(int X, int Y, int Z);

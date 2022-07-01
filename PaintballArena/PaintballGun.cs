namespace PaintballArena;

public class PaintballGun
{
    public int MagazineSize { get; private set; } = 16;
    private int _balls = 0;

    public PaintballGun(int balls, int magazineSize, bool loaded)
    {
        this._balls = balls;
        MagazineSize = magazineSize;
        if (!loaded) Reload();
    }

    public int Balls
    {
        get => _balls;
        set
        {
            if (value > 0)
                _balls = value;
            Reload();
        }
    }

    public int BallsLoaded { get; private set; } = 0;

    public bool IsEmpty()
    {
        return BallsLoaded == 0;
    }

    public void Reload()
    {
        if (_balls >= MagazineSize)
            BallsLoaded = MagazineSize;
    }

    public bool Shoot()
    {
        if (BallsLoaded == 0) return false;
        BallsLoaded--;
        _balls--;
        return true;
    }
}
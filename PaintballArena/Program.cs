using PaintballArena;

var gun = new PaintballGun(16, 16, true);
while (true)
{
    Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
    if (gun.IsEmpty()) Console.WriteLine("Warning!! You are out of ammo!");
    Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");

    var key = Console.ReadKey(true).KeyChar;
    if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
    else if (key == 'r') gun.Reload();
    else if (key == '+') gun.Balls += gun.MagazineSize;
    else if (key == 'q') return;
}
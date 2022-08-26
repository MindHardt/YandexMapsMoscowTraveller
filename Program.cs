// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome again!");
string lonOffset = (0.50f + (0.35f * Random.Shared.NextSingle())).ToString("0.000000")[2..];
string latOffset = (0.55f + (0.35f * Random.Shared.NextSingle())).ToString("0.000000")[2..];

string lon = $"37.{lonOffset}";
string lat = $"55.{latOffset}";

string url = $"https://yandex.ru/maps/213/moscow/?l=stv%2Csta&ll={lon}%2C{lat}&panorama%5B" +
    $"direction%5D=0.0%2C0.0&panorama%5Bfull%5D=true&panorama%5Bpoint%5D={lon}%2C{lat}" +
    $"&panorama%5Bspan%5D=99.608853%2C60.000000&z=100";

string path = "browser.exe";
System.Diagnostics.Process.Start(path, url);
using System;
using System.IO;

namespace Library
{
    public class ListaDeValores
    {
        string url = C:\Users\Administrador\Documents\programacion2\ej\Ejercicio4\matriz.txt;
string content = File.ReadAllText(url);
string[] contentLines = content.Split('\n');
bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
for (int  y=0; y<contentLines.Length;y++)
{
    for (int x=0; x<contentLines[y].Length; x++)
    {
        if(contentLines[y][x]=='1')
        {
            board[x,y]=true;
        }
    }
}
    }
}
